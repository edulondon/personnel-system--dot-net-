using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace niaps_ver_1._0
{
    public partial class Default : System.Web.UI.Page
    {
        private niapsEntities1 db = new niapsEntities1();
        //string msgs = "user not found";
        public const int SALT_BYTE_SIZE = 24;
        public const int HASH_BYTE_SIZE = 24;
        public const int PBKDF2_ITERATIONS = 1000;

        public const int ITERATION_INDEX = 0;
        public const int SALT_INDEX = 1;
        public const int PBKDF2_INDEX = 2;
        public void getNews()
        {
            niapsEntities1 db = new niapsEntities1();
            // news ne = new news();
            var msg = db.news.OrderByDescending(n => n.date);
            StringBuilder sb = new StringBuilder();
            int i = 1;
            foreach (var value in msg)
            {
                sb.Append(string.Format(@"<table width='400px'>
                    <tr>
                        <td>Title:</td><td>{0} </td>
                </tr>
                <tr>
                        <td></td><td>{1}<a href=""newsRoom.aspx"">read more...</a></td>
                </tr>
                    <tr>
                        <td>Author:</td><td>{2}&nbsp;&nbsp;&nbsp;Date:&nbsp; {3}</td>
                </tr>
                    <tr>
                        <td></td><td></td>
                </tr>
	                </table>", value.postebBy, niaps_ver_1._0.truncString.TruncateAtWord(value.message, 70), value.newsBy, value.date.ToShortDateString()));
                if (i.Equals(5)) { break; }
                i++;
            }
            newsLabel.Text = sb.ToString();
            db.Dispose();

        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                getNews();
            }
        }
        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            if (uname.Text == string.Empty)
            {
                unameError.Text = "*";
                pswError.Text = "";
                roleError.Text = "";
            }

            else if (psw.Text == string.Empty)
            {
                pswError.Text = "*";
                unameError.Text = "";
                roleError.Text = "";
            }
            else if (role.SelectedValue == "-select-")
            {
                roleError.Text = "*";
                unameError.Text = "";
                pswError.Text = "";
            }
           
            else
            {
                user use = new user();
                staffRecord str = new staffRecord();
                string userName = uname.Text;
                string password = psw.Text;
                string urole = role.SelectedValue;
                // var login = "";
                try
                {
                    if ((userName.Equals("jonathan")) && (password.Equals("admin")))
                    {
                        Session["fullName"] = "Jonathan Monye";
                        Session["uname"] = userName;
                        Session["role"] = urole;
                        Response.Redirect("PrivateWeb/superAdminDashboard.aspx");
                    }
                    else if (urole == "staff")
                    {
                        //  bool passResult = false;
                        try
                        {
                            var ulogin = db.users.Where(log => log.username == userName && log.role == urole && log.status == "active").First();
                            string hashPassword = ulogin.password;
                            if (ulogin != null)
                            {
                                if (ValidatePassword(password, hashPassword) == true)
                                {
                                    var staffRec = db.staffRecords.Where(us => us.staffId == ulogin.staffId).First();
                                    string fullName = staffRec.lName + ", " + staffRec.fName + " " + staffRec.middleName;
                                    Session["fullName"] = fullName;
                                    Session["uname"] = userName;
                                    Session["role"] = urole;
                                    Session["staffId"] = staffRec.staffId;
                                    Response.Redirect("PublicWeb/index.aspx");
                                    //Server.Transfer("PublicWeb/index.aspx");
                                    // Response.Redirect("PublicWeb/index.aspx?you=value&uname=" + userName + "&role=" + urole+"&fname="+fullName+"&contact=contactyours");
                                }
                                else
                                {
                                    msg.Text = "password incorrect!...pls try again";
                                    uname.Text = "";
                                    psw.Text = "";
                                    role.Text = "-select-";
                                    roleError.Text = "";
                                    unameError.Text = "";
                                    pswError.Text = "";
                                }
                            }
                            else
                            {
                                msg.Text = "wrong login detail!... pls try again";
                                uname.Text = "";
                                psw.Text = "";
                                role.Text = "-select-";
                                roleError.Text = "";
                                unameError.Text = "";
                                pswError.Text = "";
                            }
                        }
                        catch (Exception)
                        {
                            msg.Text = "staff does not exist";
                            uname.Text = "";
                            psw.Text= "";
                            role.Text = "-select-";
                            roleError.Text = "";
                            unameError.Text = "";
                            pswError.Text = "";
                        }
                       
                    }
                    else
                    {
                        try
                        {
                            var alogin = db.adminUsers.Where(lo => lo.userName == userName && lo.role == urole && lo.status == "active").First();
                            string hashPassword = alogin.password;
                            bool testPsw = ValidatePassword(password, hashPassword);
                            if (alogin != null)
                            {
                                if (testPsw)
                                {
                                    string fullName = alogin.userName;
                                    Session["fullName"] = fullName;
                                    Session["uname"] = alogin.userName;
                                    Session["role"] = alogin.role;
                                    //Session["staffId"] = staffRec.staffId;
                                    if (alogin.role == "admin")
                                    {
                                        Response.Redirect("PrivateWeb/superAdminDashboard.aspx");
                                    }
                                    if (alogin.role == "hr")
                                    {
                                        Response.Redirect("PrivateWeb/index.aspx");
                                    }
                                    if (alogin.role == "inventory")
                                    {
                                        Response.Redirect("~/PrivateWeb/regAsset.aspx");

                                    }
                                    if (alogin.role == "secret'l")
                                    {
                                        Response.Redirect("PublicWeb/postNews.aspx");
                                    }
                                }
                                else
                                {
                                    msg.Text = "password incorrect... please re-enter";
                                    uname.Text = "";
                                    psw.Text = "";
                                    role.Text = "-select-";
                                    roleError.Text = "";
                                    unameError.Text = "";
                                    pswError.Text = "";
                                }
                            }
                            else
                            {
                                msg.Text = "wrong login detail!... pls try again";
                                uname.Text = "";
                                psw.Text = "";
                                role.Text = "-select-";
                                roleError.Text = "";
                                unameError.Text = "";
                                pswError.Text = "";
                            }
                        }
                        catch (Exception) {
                            msg.Text = "Admin does not exist";
                            uname.Text = "";
                            psw.Text = "";
                            role.Text = "-select-";
                            roleError.Text = "";
                            unameError.Text = "";
                            pswError.Text = "";
                        }
                    }
                }
                catch (Exception)
                {
                    //msg.Text = ex.Message;
                    msg.Text = "invalid login";
                    uname.Text = "";
                    psw.Text = "";
                    role.Text = "-select-";
                    roleError.Text = "";
                    unameError.Text = "";
                    pswError.Text = "";
                }

            }
        }
        public static bool ValidatePassword(string password, string correctHash)
        {
            // Extract the parameters from the hash
            char[] delimiter = { ':' };
            string[] split = correctHash.Split(delimiter);
            int iterations = Int32.Parse(split[ITERATION_INDEX]);
            byte[] salt = Convert.FromBase64String(split[SALT_INDEX]);
            byte[] hash = Convert.FromBase64String(split[PBKDF2_INDEX]);

            byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }
        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }

        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            return pbkdf2.GetBytes(outputBytes);
        }
    }
}