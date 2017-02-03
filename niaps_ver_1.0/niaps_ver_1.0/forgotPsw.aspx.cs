using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0
{
    public partial class forgotPsw : System.Web.UI.Page
    {
        niapsEntities1 db = new niapsEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void send_Click(object sender, EventArgs e)
        {
            try
            {
                string temPsw = randomPsw();
                var query = db.users.FirstOrDefault(qu => qu.email == uname.Text);
                if (query != null)
                {
                    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                    mail.To.Add(uname.Text);
                    mail.From = new MailAddress("niaps.ver.1@gmail.com", "NIAPS", System.Text.Encoding.UTF8);
                    mail.Subject = "Your Regenarated Password";
                    mail.SubjectEncoding = System.Text.Encoding.UTF8;
                    mail.Body = "Your new password is: " + temPsw;
                    mail.BodyEncoding = System.Text.Encoding.UTF8;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.High;
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new System.Net.NetworkCredential("niaps.ver.1@gmail.com", "niaps123");
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Send(mail);
                    msg.Text = "an email has been sent to your inbox. Check your mail for the generated password";
                    query.password = CreateHash(temPsw);
                    db.SaveChanges();
                }
                else { check.Text = "email does not exist in the database"; }
            }
            catch (Exception)
            {
                check.Text = "could not send email";
            }
        }
        public const int SALT_BYTE_SIZE = 24;
        public const int HASH_BYTE_SIZE = 24;
        public const int PBKDF2_ITERATIONS = 1000;

        public const int ITERATION_INDEX = 0;
        public const int SALT_INDEX = 1;
        public const int PBKDF2_INDEX = 2;

        public static string CreateHash(string password)
        {
            // Generate a random salt
            RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_BYTE_SIZE];
            csprng.GetBytes(salt);

            // Hash the password and encode the parameters
            byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE);
            return PBKDF2_ITERATIONS + ":" +
                Convert.ToBase64String(salt) + ":" +
                Convert.ToBase64String(hash);
        }
        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            return pbkdf2.GetBytes(outputBytes);
        }
        public string randomPsw()
        {
            Random adomRng = new Random();
            string rndString = string.Empty;
            char c;

            for (int i = 0; i < 8; i++)
            {
                while (!Regex.IsMatch((c = Convert.ToChar(adomRng.Next(48, 128))).ToString(), "[A-Za-z0-9]")) ;
                rndString += c;
            }

            return rndString;
        }
    }
}