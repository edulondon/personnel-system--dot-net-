using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0
{
    public partial class staffRecDataSheetUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string path = string.Concat((Server.MapPath("~/temp/" + FileUpload1.FileName)));
                FileUpload1.PostedFile.SaveAs(path);
                OleDbConnection OleDbcon = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;");
                OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$]", OleDbcon);
                OleDbDataAdapter odr = new OleDbDataAdapter(cmd);

                OleDbcon.Open();
                DataSet ds = new DataSet();
                odr.Fill(ds);
                odr.Dispose();
                OleDbcon.Close();
                OleDbcon.Dispose();

                using (niapsEntities1 db = new niapsEntities1())
                {
                    
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        try
                        {
                            staffRecord sr = new staffRecord();
                            sr.staffId = dr["staffIdNo"].ToString();
                            sr.fName = dr["FirstName"].ToString();
                            sr.lName = dr["LastName"].ToString();
                            sr.gender = dr["Gender"].ToString();
                            string dateString = dr["date_of_birth"].ToString();
                            DateTime result;
                            result = DateTime.Parse(dateString);
                            sr.dateOfBirth = result;
                            string staffAge = ((DateTime.Now.Year) - (result.Year)).ToString();
                            sr.email = dr["email"].ToString();
                            sr.mobile = dr["mobile"].ToString();
                            sr.address = dr["address"].ToString();
                            sr.state = dr["state_of_origin"].ToString();
                            sr.Lga = dr["lga"].ToString();
                            sr.middleName = dr["MiddleName"].ToString();
                            sr.marritalStatus = dr["mStatus"].ToString();
                            sr.formOfIdentification = dr["form_of_identity"].ToString();
                            sr.passport = dr["passportLink"].ToString();
                            sr.age = Int32.Parse(staffAge);
                            sr.idNumber = dr["id_number"].ToString();
                            sr.status = "active";
                            db.staffRecords.Add(sr);
                            db.SaveChanges();

                    //populate user table with staff login parameters
                    staffNextOfKin st = new staffNextOfKin();
                    st.staffId = dr["staffIdNo"].ToString();
                    st.fName = dr["nFirstName"].ToString();
                    st.lname = dr["last_name"].ToString();
                    st.gender = dr["gender"].ToString();
                    st.address = dr["address"].ToString();
                    st.contactMobile =dr["phone"].ToString();
                    st.relationship = dr["relationship"].ToString();
                    db.staffNextOfKins.Add(st);
                    db.SaveChanges();

                    user use = new user();
                    use.email = dr["email"].ToString();
                    use.staffId = dr["staffIdNo"].ToString();
                    use.role = "staff";
                    use.username = dr["userName"].ToString();
                    string temPsw = randomPsw();
                    use.password = CreateHash(temPsw);
                    use.status = "active";
                    db.users.Add(use);
                    db.SaveChanges();


                     System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                        mail.To.Add(dr["email"].ToString());
                        mail.From = new MailAddress("niaps.ver.1@gmail.com", "NIA Personnel System", System.Text.Encoding.UTF8);
                        mail.Subject = "Your NIAPS Logon Detail";
                        mail.SubjectEncoding = System.Text.Encoding.UTF8;
                        mail.Body = "Your account details on NIA Personnel System (NIAPS) are: <b />user name =" + dr["userName"].ToString() + " <b />password =" + temPsw;
                        mail.BodyEncoding = System.Text.Encoding.UTF8;
                        mail.IsBodyHtml = true;
                        mail.Priority = MailPriority.High;
                        SmtpClient client = new SmtpClient();
                        client.Credentials = new System.Net.NetworkCredential("niaps.ver.1@gmail.com", "niaps123");
                        client.Port = 587;
                        client.Host = "smtp.gmail.com";
                        client.EnableSsl = true;
                        client.Send(mail);
                        }
                        catch (Exception ex)
                        {
                            //continue;
                            //Label1.ForeColor = Color.Red;
                            Label1.Text = ex.Message;
                        }
                    }

                }
                    Label1.ForeColor = Color.Green;
                    Label1.Text = "Successfully inserted";
                
            }
            else
            {
                Label1.ForeColor = Color.Red;
                Label1.Text = "Please select the file";
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