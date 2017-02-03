﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class smodifyUserPassword : System.Web.UI.Page
    {
        public const int SALT_BYTE_SIZE = 24;
        public const int HASH_BYTE_SIZE = 24;
        public const int PBKDF2_ITERATIONS = 1000;

        public const int ITERATION_INDEX = 0;
        public const int SALT_INDEX = 1;
        public const int PBKDF2_INDEX = 2;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // string name = Session["fullName"].ToString();
                string role = Session["role"].ToString();
                // string staffId = Session["staffid"].ToString();
            }
            catch (Exception)
            {
                Response.Redirect("../Default.aspx");
            }
        }

        protected void modify_Click(object sender, EventArgs e)
        {
            try
            {
                string firstPsw = psw.Text;
                string confirmPsw = cpsw.Text;

                if (firstPsw == confirmPsw)
                {
                    niapsEntities1 ctx = new niapsEntities1();
                    int id = Int32.Parse(Request.QueryString["uid"].ToString());
                    var result = ctx.adminUsers.FirstOrDefault(us => us.userId == id);
                    result.password = CreateHash(firstPsw);
                    ctx.SaveChanges();
                    msg.Text = "Password modified successfully";
                    cpsw.Text = "";
                    psw.Text = "";
                }
                else
                {
                    msg.Text = "Password does not match! try again";
                }
            }
            catch
            {
                msg.Text = "Password does not match! try again";
            }
        }
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