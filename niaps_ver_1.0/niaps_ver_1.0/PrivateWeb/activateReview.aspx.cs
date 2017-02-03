using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class activateReview : System.Web.UI.Page
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

        protected void activate_Click(object sender, EventArgs e)
        {
            //string ms = null;
            try
            {
                activateReview review = new activateReview();
                string qatr = qtr.SelectedValue;
                string years = yr.SelectedValue;
                string stat = act.Text;
                
            db.SaveChanges();
            
                
            }
            catch { 
            var com = db.activateReviews.Where(co => co.Id == 1).First();
            int id = com.Id;
            var cstatus = db.activateReviews.FirstOrDefault(cs => cs.Id == 1);
            if (act.Checked)
            {
                cstatus.status = "active";
                msg.Text = "appraisal activated";
            }
            else
            {
                cstatus.status = "inactive";
                msg.Text = "appraisal deactivated";
            }
            db.SaveChanges();
            }
        }
    }
}