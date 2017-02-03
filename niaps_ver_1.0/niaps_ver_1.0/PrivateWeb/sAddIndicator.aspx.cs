using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class sAddIndicator : System.Web.UI.Page
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
            try
            {
                var idc = db.indicators.FirstOrDefault(ic=>ic.IndicatorId=="fi");
                idc.quarter = qtr.SelectedValue;
                idc.year = yr.SelectedValue;
                db.SaveChanges();
                db.Dispose();
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""indicator added successfully... click OK to continue!"")</SCRIPT>"));
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""superAdminDashboard.aspx"") </SCRIPT>"));
            }
            catch (Exception) {
                msg.Text = "update failed... pls, try again";
            } 
        }
    }
}