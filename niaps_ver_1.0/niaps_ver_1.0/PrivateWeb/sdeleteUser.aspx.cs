using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{

    public partial class sdeleteUser : System.Web.UI.Page
    {
        niapsEntities1 db = new niapsEntities1();
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

            string un = Request.QueryString["uname"];
            string rols = Request.QueryString["role"];
            // string stat = Request.QueryString["status"];
            uname.Text = un;
            rol.Text = rols;
            //if (stat.Equals("active")) { dt.Checked = false; } else { dt.Checked = true; }



        }

        protected void deleteUser_Click(object sender, EventArgs e)
        {
            {
                if (dt.Checked)
                {
                    int uId = Int32.Parse(Request.QueryString["uid"].ToString());
                    var stud = new adminUser { userId = uId };
                    db.adminUsers.Attach(stud);
                    db.adminUsers.Remove(stud);
                    db.SaveChanges();
                    uname.Text = "";
                    rol.Text = "";
                    dt.Checked = false;
                    msg.Text = "user deleted successfully";
                    // Response.Redirect("sviewUsers.aspx?msg="+msg);
                }
                else
                {
                    msg.Text = "Please Check the delete box to confirm";
                    // Response.Redirect("sviewUsers.aspx?msg=" + msg);
                }

            }
        }
    }
}