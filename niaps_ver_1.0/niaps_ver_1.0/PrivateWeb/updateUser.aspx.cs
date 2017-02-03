using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateUser : System.Web.UI.Page
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
        }

        protected void done_Click(object sender, EventArgs e)
        {
            int uId = Int32.Parse(Request.QueryString["uid"].ToString());
            var update = db.adminUsers.FirstOrDefault(cs => cs.userId == uId);
            if (dt.Checked)
            {
                update.status = "inactive";
            }
            else
            {
                update.status = "active";
            }
            db.SaveChanges();
            msg.Text = "updated successfully";
            
        }
    }
}