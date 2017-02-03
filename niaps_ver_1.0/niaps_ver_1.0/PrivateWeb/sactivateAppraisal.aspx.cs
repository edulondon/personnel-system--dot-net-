using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class sactivateAppraisal : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                var com = db.activateReviews.Where(co => co.Id == 1).First();
                if (com.status.Equals("active"))
                {
                    act.Checked = true;
                }
                else
                {
                    act.Checked = false;
                }
            }
        }

        protected void activate_Click(object sender, EventArgs e)
        {
            try
            {
                var com = db.activateReviews.Where(co => co.Id == 1).First();
                int id = com.Id;
                var cstatus = db.activateReviews.FirstOrDefault(cs => cs.Id == 1);
                if (act.Checked)
                {
                    cstatus.status = "active";
                    cstatus.reviewId = id + 1;
                    string qatr = qtr.SelectedValue;
                    string years = yr.SelectedValue;
                    string stat = act.Text;
                    //  msg.Text = "appraisal activated successfully";
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""appraisal activated successfully... click OK to continue!"")</SCRIPT>"));
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""superAdminDashboard.aspx"") </SCRIPT>"));

                }
                else
                {
                    cstatus.status = "inactive";
                    cstatus.reviewId = id - 1;
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""appraisal deactivated successfully... click OK to continue!"")</SCRIPT>"));
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""superAdminDashboard.aspx"") </SCRIPT>"));
                   // msg.Text = "appraisal deactivated successfully";
                }
                db.SaveChanges();
            }
            catch (Exception) {
                msg.Text = "action failed... try again!";
            }
        }
    }
}