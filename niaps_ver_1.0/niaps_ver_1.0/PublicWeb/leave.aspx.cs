using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class leave : System.Web.UI.Page
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
            //var pl = db.pendingLeaves.Where(p => p.staffId == sId).First();
            //pdl.Text = pl.staffPendingLeave;
            try
            {
                // string sId = Request.QueryString["staffId"].ToString();

                string sId = Session["staffId"].ToString();
                // news ne = new news();
                var query = db.leaves.Where(l => l.staffId == sId).First();
                if (query != null && query.ToString() != "")
                {
                    staffid.Text = query.staffId;
                    sname.Text = query.name;
                    sdate.Text = query.startDate.ToShortDateString();
                    rdate.Text = query.endDate.ToShortDateString();
                    leavep.Text = (query.totalUnusedLeaveDays).ToString();
                    gld.Text = (query.leaveDaysGranted).ToString();
                }
                else
                {
                    string msg = "No available Leave for you";
                    Response.Redirect("message.aspx?msg=" + msg);
                }
            }
            catch (Exception)
            {
                msg.Text = "Your leave for the year hasn't been scheduled. Pls, contact HR!";
            }
        }


    }
}