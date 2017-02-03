using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Threading;
//using System.Globalization;

namespace niaps_ver_1._0
{
    public partial class dateText : System.Web.UI.Page
    {
        //public const int SALT_BYTE_SIZE = 24;
        //public const int HASH_BYTE_SIZE = 24;
        //public const int PBKDF2_ITERATIONS = 1000;

        //public const int ITERATION_INDEX = 0;
        //public const int SALT_INDEX = 1;
        //public const int PBKDF2_INDEX = 2;

        //public static string CreateHash(string password)
        //{
        // Generate a random salt
        //RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
        //byte[] salt = new byte[SALT_BYTE_SIZE];
        //csprng.GetBytes(salt);

        //// Hash the password and encode the parameters
        //byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE);
        //return PBKDF2_ITERATIONS + ":" +
        //    Convert.ToBase64String(salt) + ":" +
        //Convert.ToBase64String(hash);
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //btnPost.Attributes.Add("onclick", "javascript:alert('update successful<br/> Click Ok to continue');");
            //double dblValue = 12445.6789;
            //Label1.Text = dblValue.ToString("N", CultureInfo.InvariantCulture);
            // Displays -12,445.68
            //Console.WriteLine(dblValue.ToString("N1",
            //                  CultureInfo.CreateSpecificCulture("sv-SE")));
            //// Displays -12 445,7 

            //int intValue = 123456789;
            //Console.WriteLine(intValue.ToString("N1", CultureInfo.InvariantCulture));

            //Double intValue = 1234;
            //string html = (intValue.ToString("N2", CultureInfo.InvariantCulture));
            //decimal html1 = Convert.ToDecimal(html);
            //Label1.Text = (html1).ToString();

            //string dateJoined2 = "2-2-2013";
            //string dateLeft2 = "2-2-2014";
            //DateTime coverD = DateTime.Parse(dateJoined2);
            //DateTime expiryD = DateTime.Parse(dateLeft2);
            //if (coverD > expiryD)
            //{
            //    Label1.Text = "cover date cannot be > than date expiry date";
            //}
            //else
            //{
            //    Label1.Text = (expiryD.Year-coverD.Year).ToString();
            //}

            //string has = "1000:X1Jrw84MEYclmtujjSUjbhNMw++z7gtR:4bpiF/yJbqGucxWGvhOAn22TwHQSTlwn";
            //Label1.Text = (ValidatePassword("Davis", has)).ToString();
        }


        protected void btnPost_Click(object sender, EventArgs e)
        {
            string d = dates.Text;
            string d2 = dates.Text;
            CultureInfo provider = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = provider;
            DateTime date1 = DateTime.Parse(d);
            DateTime date2 = DateTime.Parse(d2);
            int dat = date1.Year;
            int da = date2.Year;
            int result = da - dat;
            Label1.Text = (result).ToString();
        //    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
        //    mail.To.Add("niaps.ver.1@gmail.com");
        //    mail.From = new MailAddress("niaps.ver.1@gmail.com", "Email head", System.Text.Encoding.UTF8);
        //    mail.Subject = "This mail is send from asp.net application";
        //    mail.SubjectEncoding = System.Text.Encoding.UTF8;
        //    mail.Body = "This is Email Body Text";
        //    mail.BodyEncoding = System.Text.Encoding.UTF8;
        //    mail.IsBodyHtml = true;
        //    mail.Priority = MailPriority.High;
        //    SmtpClient client = new SmtpClient();
        //    client.Credentials = new System.Net.NetworkCredential("niaps.ver.1@gmail.com", "niaps123");
        //    client.Port = 587;
        //    client.Host = "smtp.gmail.com";
        //    client.EnableSsl = true;
        //    try
        //    {
        //        client.Send(mail);
        //        Page.RegisterStartupScript("UserMsg", "<script>alert('Successfully Send...');</script>");
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception ex2 = ex;
        //        string errorMessage = string.Empty;
        //        while (ex2 != null)
        //        {
        //            errorMessage += ex2.ToString();
        //            ex2 = ex2.InnerException;
        //        }
        //        Page.RegisterStartupScript("UserMsg", "<script>alert('Sending Failed...');</script>");

                //if (dates.Text != string.Empty)
                //{
                //    Label1.Text = "pass";
                //    error.Text = "";
                //    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Hello this is an Alert"")</SCRIPT>"));
                //}
                //else {
                //    error.Text = "failed";
                //    Label1.Text = "";
                //}


                //Exception X = new Exception();

                //TextBox T = (TextBox)sender;

                //try
                //{
                //    if (T.Text != "-")
                //    {
                //        int x = int.Parse(T.Text);
                //    }
                //}
                //catch (Exception)
                //{
                //    try
                //    {
                //        int CursorIndex = T.SelectionStart - 1;
                //        T.Text = T.Text.Remove(CursorIndex, 1);

                //        //Align Cursor to same index
                //        T.SelectionStart = CursorIndex;
                //        T.SelectionLength = 0;
                //    }
                //    catch (Exception) { }
                //}
                // string psw = dates.Text;
                //  Label1.Text = CreateHash(psw);

                // string d0 = dates.Text;
                // CultureInfo ci = new CultureInfo("en-GB");
                //Thread.CurrentThread.CurrentCulture = ci;
                // DateTime d1 = DateTime.Parse(d0);
                //  //DateTime d2 = DateTime.Now;
                //  //TimeSpan d3 = d2. Subtract(d1); // subtract d1 from d2
                // int days = d1.Day;
                // int months = d1.Month + 1;
                // int years = d1.Year;
                //  Label1.Text = "no of days is :"+days.ToString()+"no of months is: "+ months.ToString()+"and year is: "+years;
                // // string d4 = (d3.Duration()).ToString();

                //  Label1.Text += "Days in Feb: " + DateTime.DaysInMonth(2014, 02);

                //string input = dates.Text;
                //Label1.Text = hashPsw(input);


                // //CultureInfo ci = new CultureInfo("en-GB");
                // //Thread.CurrentThread.CurrentCulture = ci;
                // //string fromDate = dates.Text;
                // //DateTime dt = DateTime.Parse(fromDate);

                // //Label1.Text = dt.ToString();
                // string dateString = dates.Text;
                // DateTime result;
                // CultureInfo provider = new CultureInfo("en-GB");
                // Thread.CurrentThread.CurrentCulture = provider;
                //// format = "DD/MM/yyyy";
                // result = DateTime.Parse(dateString);
                // string staffAge = ((DateTime.Now.Year) - (result.Year)).ToString();     
                // Label1.Text = result.ToString();
                // Label1.Text += " Age: " + staffAge;

                // Random Password....
                //string pool = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                //int count = 0;
                //        Label1.Text = "";
                //        int length = 8;
                //        Random cc = new Random();
                //        var strpos = "";
                //        while (count <= length){
                //            strpos = cc.Next(0, pool.Length).ToString();

                //        Label1.Text = Label1.Text + strpos;
                //        count = count + 1;
                //}
                // Random adomRng = new Random();
                //string rndString = string.Empty;
                //char c;

                //for (int i = 0; i < 8; i++)
                //{
                //    while (!Regex.IsMatch((c=Convert.ToChar(adomRng.Next(48,128))).ToString(), "[A-Za-z0-9]"));
                //    rndString += c;
                //}

                //Label1.Text = rndString;

                //Sending mail messages...


                //MailMessage mail = new MailMessage();
                //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //mail.From = new MailAddress("monyejoe@gmail.com");
                //mail.To.Add("u@urdomain.com");
                //mail.Subject = "Testing";
                //mail.Body = "Report";

                //SmtpServer.Port = 25;
                //SmtpServer.Credentials = new System.Net.NetworkCredential("monyejoe@gmail.com", "password");
                //SmtpServer.EnableSsl = true;

                //SmtpServer.Send(mail);



            }



            //public static bool ValidatePassword(string password, string correctHash)
            //{
            //    // Extract the parameters from the hash
            //    char[] delimiter = { ':' };
            //    string[] split = correctHash.Split(delimiter);
            //    int iterations = Int32.Parse(split[ITERATION_INDEX]);
            //    byte[] salt = Convert.FromBase64String(split[SALT_INDEX]);
            //    byte[] hash = Convert.FromBase64String(split[PBKDF2_INDEX]);

            //    byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
            //    return SlowEquals(hash, testHash);
            //}
            //private static bool SlowEquals(byte[] a, byte[] b)
            //{
            //    uint diff = (uint)a.Length ^ (uint)b.Length;
            //    for (int i = 0; i < a.Length && i < b.Length; i++)
            //        diff |= (uint)(a[i] ^ b[i]);
            //    return diff == 0;
            //}

            //private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
            //{
            //    Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            //    pbkdf2.IterationCount = iterations;
            //    return pbkdf2.GetBytes(outputBytes);
            //}
        
    }
    }
