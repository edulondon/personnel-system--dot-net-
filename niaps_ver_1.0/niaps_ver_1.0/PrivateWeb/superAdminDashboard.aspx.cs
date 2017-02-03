using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class superAdminDashboard : System.Web.UI.Page
    {
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
                usname.Text = "";
                psword.Text = "";
                roles.Text = "-select-";
                fname.Text = "";
            }
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
                adminUser admu = new adminUser();
                if (usname.Text == string.Empty)
                {
                    unameMsg.Text = "*";
                    pswMsg.Text = "";
                    fnameMsg.Text = "";
                }
                else   if (psword.Text == string.Empty)
                    {
                        pswMsg.Text = "*";
                        fnameMsg.Text = "";
                        unameMsg.Text = "";
                    }
                else if (fname.Text == string.Empty)
                {
                    fnameMsg.Text = "*";
                    unameMsg.Text = "";
                    pswMsg.Text = "";
                }else{

                    try
                    {
                        var test = db.adminUsers.Where(u => u.userName == usname.Text).First();
                        if (test.userName != string.Empty)
                        {
                            unameMsg.Text = "user name already taken";
                        }
                    }
                    catch (Exception)
                    {
                        admu.userName = usname.Text;
                        admu.full_name = fname.Text;
                        admu.password = CreateHash(psword.Text);
                        admu.role = roles.SelectedValue;
                        admu.status = "active";
                        db.adminUsers.Add(admu);
                        db.SaveChanges();
                        unameMsg.Text = "";
                        usname.Text = "";
                        psword.Text = "";
                        pswMsg.Text = "";
                        fname.Text = "";
                        fnameMsg.Text = "";
                        roles.Text = "-select-";
                        msg.Text = "User Created Successfully";
                    }
                    
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