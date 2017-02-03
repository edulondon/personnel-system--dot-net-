using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Globalization;
using System.Web.Security;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Security.Cryptography;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class createStaff : System.Web.UI.Page
    {
        private niapsEntities1 db = new niapsEntities1(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string name = Session["fullName"].ToString();
                string role = Session["role"].ToString();
            }
            catch (Exception)
            {
                Response.Redirect("../Default.aspx");
            }
            if (!IsPostBack)
            {
                fname.Text = "";
                klname.Text = "";
                sex.Text = "";
                kaddr.Text = "";
                phone.Text = "";
                rel.Text = "";
                basicQ.Text = "";
                dop.Text = "";
                userName.Text = "";
                degree.Text = "";
                inst.Text = "";
                sid.Text = "";
                fname.Text = "";
                lname.Text = "";
                gender.Text = "";
                dob.Text = "";
               
                mobile.Text = "";
                addr.Text = "";
                // ddState.Text = "";
                // ddLga.Text = "";
                mname.Text = "";
                ms.Text = "";
                foid.Text = "";
                email.Text = "";
            }

            //string theFile = txtFile.PostedFile.FileName;
        }


        protected void lga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void create_Click(object sender, EventArgs e)
        {
            if (sid.Text == string.Empty)
            {
                sidError.Text = "*";
            }
            else if (fname.Text == string.Empty) { fnameError.Text = "*"; }
            else if (mname.Text == string.Empty) { mError.Text = "*"; }
            else if (lname.Text == string.Empty) { lError.Text = "*"; }
            else if (dob.Text == string.Empty) { dobError.Text = "*"; }
            else if (gender.Text.Equals("-select-")) { genderError.Text = "*"; }
            else if (ms.Text.Equals("-select-")) { msError.Text = "*"; }
            else if (mobile.Text == string.Empty) { mobileError.Text = "*"; }
            else if (addr.Text == string.Empty) { addrError.Text = "*"; }
            else if (email.Text == string.Empty) { eError.Text = "*"; }
            else if (foid.Text == string.Empty) { msg.Text = "*"; }
            else if (basicQ.Text == string.Empty) { bqError.Text = "*"; }
            else if (inst.Text == string.Empty) { iError.Text = "*"; }
            else if (degree.Text == string.Empty) { dgError.Text = "*"; }
            else if (ddLga.Text.Equals("-select-")) { lgaError.Text = "*"; }
            else if (ddState.Text.Equals("-select-")) { lgaError.Text = "*"; }
            else if (rel.Text == string.Empty) { relError.Text = "*"; }
            else if (phone.Text == string.Empty) { gsmError.Text = "*"; }
            else if (kaddr.Text == string.Empty) { kaddrError.Text = "*"; }
            else if (sex.Text.Equals("-select-")) { sexError.Text = "*"; }
            else if (klname.Text == string.Empty) { klnError.Text = "*"; }
            else if (userName.Text == string.Empty) { userError.Text = "*"; } 
           // else if (dop.Text == string.Empty) { msg.Text = "*"; }
            else if (txtFile.FileName == string.Empty) { pp.Text = "*"; }
            else if (kfname.Text == string.Empty) { kfnError.Text = "*"; }
            else
            {
                string dateOB = dob.Text;
                string dateO = dop.Text;
                DateTime dateOfBirth = DateTime.Parse(dateOB);

                DateTime dateOptained = DateTime.Parse(dateO);
                int i = dateOptained.Year - dateOfBirth.Year;
                if (i < 14)
                {
                    dateError.Text = "invalid date";
                }

                staffRecord sr = new staffRecord();
                try
                {
                    sr.staffId = sid.Text;
                    sr.fName = fname.Text;
                    sr.lName = lname.Text;
                    sr.gender = gender.SelectedValue;
                    string dateString = dob.Text;
                    DateTime result;
                    result = DateTime.Parse(dateString);
                    sr.dateOfBirth = result;
                    string staffAge = ((DateTime.Now.Year) - (result.Year)).ToString();
                    sr.email = email.Text;
                    sr.mobile = mobile.Text;
                    sr.address = addr.Text;
                    sr.state = ddState.SelectedValue.ToString();
                    sr.Lga = ddLga.SelectedValue.ToString();
                    sr.middleName = mname.Text;
                    sr.marritalStatus = ms.Text;
                    sr.formOfIdentification = foid.Text;
                    string theFile = txtFile.PostedFile.FileName;
                    string filepath = MapPath("images/") + theFile;
                    try
                    {
                        txtFile.PostedFile.SaveAs(filepath);

                    }
                    catch (Exception)
                    {
                        msg.Text = "Record was not saved!";
                       // msg.Text += fx.Message;
                    }

                    sr.passport = "~/PrivateWeb/images/" + theFile.ToString();
                    sr.age = Int32.Parse(staffAge);
                    sr.idNumber = pid.Text;
                    sr.status = "active";
                    db.staffRecords.Add(sr);
                    db.SaveChanges();

                    //populate user table with staff login parameters
                    user use = new user();

                    use.email = email.Text;
                    use.staffId = sid.Text;
                    use.role = "staff";
                    use.username = userName.Text;
                    string temPsw = randomPsw();
                    use.password = CreateHash(temPsw);
                    use.status = "active";
                    db.users.Add(use);
                    db.SaveChanges();


                    qualification qu = new qualification();

                    string bq = basicQ.Text;
                    string dg = degree.Text;
                    Session["basicqualification"] = bq;
                    Session["degree"] = dg;
                    qu.staffId = sid.Text;
                    qu.name = basicQ.Text;
                    if (dop.Text != string.Empty)
                    {
                        string result2 = dop.Text;
                        DateTime dateo = DateTime.Parse(result2);
                        qu.dateObtained = dateo;
                    }
                    else
                    {
                        dateError.Text = "*";

                    }

                    qu.typeOfQualification = degree.Text;
                    qu.institution = inst.Text;
                    db.qualifications.Add(qu);
                    db.SaveChanges();
                    //  Response.Redirect("enterEmploymentRecord.aspx?staffId=" + sid.Text);



                    staffNextOfKin st = new staffNextOfKin();

                    st.staffId = sid.Text;
                    st.fName = kfname.Text;
                    st.lname = klname.Text;
                    st.gender = sex.Text;
                    st.address = kaddr.Text;
                    st.contactMobile = phone.Text;
                    st.relationship = rel.Text;
                    db.staffNextOfKins.Add(st);
                    db.SaveChanges();


                    pendingLeave pl = new pendingLeave();
                    pl.staffId = sid.Text;
                    pl.staffPendingLeave = 0;
                    db.pendingLeaves.Add(pl);
                    db.SaveChanges();
                    try
                    {
                        System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                        mail.To.Add(email.Text);
                        mail.From = new MailAddress("niaps.ver.1@gmail.com", "NIAPS", System.Text.Encoding.UTF8);
                        mail.Subject = "Your NIAPS Logon Detail";
                        mail.SubjectEncoding = System.Text.Encoding.UTF8;
                        mail.Body = "Your account details on NIA Personnel System (NIAPS) are: <b />user name =" + userName.Text + " <b />password =" + temPsw;
                        mail.BodyEncoding = System.Text.Encoding.UTF8;
                        mail.IsBodyHtml = true;
                        mail.Priority = MailPriority.High;
                        SmtpClient client = new SmtpClient();
                        client.Credentials = new System.Net.NetworkCredential("niaps.ver.1@gmail.com", "niaps123");
                        client.Port = 587;
                        client.Host = "smtp.gmail.com";
                        client.EnableSsl = true;
                        client.Send(mail);
                        Response.Redirect("enterEmploymentRecord.aspx?staffId=" + sid.Text + "&lname=" + lname.Text + "&fname=" + fname.Text + "&mname=" + mname.Text  +"&bq="+ bq + "&degree=" + dg);
                    }
                    catch (Exception) {
                        Response.Redirect("enterEmploymentRecord.aspx?staffId=" + sid.Text + "&lname=" + lname.Text + "&fname=" + fname.Text + "&mname=" + mname.Text + "&bq=" + bq + "&degree=" + dg);
                    }
                }
                catch (FormatException)
                {
                    msg.Text = "error, Could not create staff";
                }
                catch (Exception)
                {
                    msg.Text ="Could not create staff.. Staff already exist";
                }
            }

        }
        protected void state_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    Bind_lga();
            //}
            var query = from c in db.LGAs
                        where c.stateCode == ddState.SelectedValue
                        // where c.Merchant.Merchant_ID == id
                        select c;

            ddLga.DataValueField = "LGACode";
            ddLga.DataTextField = "name";
            ddLga.DataSource = query.ToList();
            ddLga.DataBind();

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
        //public string hashPsw(string psw){

        //    string hashresult = FormsAuthentication.HashPasswordForStoringInConfigFile("psw", "SHA1");
        //        return hashresult;
        //}

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

        protected void email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void dob_TextChanged(object sender, EventArgs e)
        {
            dobError.Text = "";
            string dateOB = dob.Text;
            DateTime dateOfBirth = DateTime.Parse(dateOB);
            DateTime deteo = DateTime.Now;
            int i = deteo.Year - dateOfBirth.Year;
            if (i < 16)
            {
                dobError.Text = "invalid date";
            }
        }

        protected void dop_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dateError.Text = "";
                string dateOB = dob.Text;
                string dateO = dop.Text;
                DateTime dateOfBirth = DateTime.Parse(dateOB);
                DateTime dateOptained = DateTime.Parse(dateO);
                int i = dateOptained.Year - dateOfBirth.Year;
                if (i < 16)
                {
                    dateError.Text = "invalid date";
                }
                DateTime current = DateTime.Now;
                if (dateOptained.Year > current.Year)
                {
                    dateError.Text = "invalid date";
                }
                if ((dateOptained.Year == current.Year) && (dateOptained.Month > current.Month))
                {
                    dateError.Text = "invalid date";
                }
            }
            catch (Exception)
            {
                dateError.Text = "invalid date";
            }
        }
            
            
        }
    }
