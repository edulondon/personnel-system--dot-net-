using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class supdateUser : System.Web.UI.Page
    {
        niapsEntities1 db = new niapsEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int uId = Int32.Parse(Request.QueryString["uid"].ToString());

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
                string un = Request.QueryString["uname"];
                string rols = Request.QueryString["role"];
                string stat = Request.QueryString["status"];
                uname.Text = un;
                rol.Text = rols;
                if (stat.Equals("active")) { dt.Checked = false; } else { dt.Checked = true; }
            }

        }
        protected void update_Click(object sender, EventArgs e)
        {
            int uId = Int32.Parse(Request.QueryString["uid"].ToString());
            var update = db.adminUsers.FirstOrDefault(cs => cs.userId == uId);
            if (dt.Checked)
            {
                update.status = "inactive";
                db.SaveChanges();
                msg.Text = "user deactivated";
                // Response.Redirect("sviewUsers.aspx?msg=" + msgs);
            }
            else
            {
                update.status = "active";
                db.SaveChanges();
                msg.Text = "user activated";
                //  Response.Redirect("sviewUsers.aspx?msg=" + mesg);
            }



        }
    }
}