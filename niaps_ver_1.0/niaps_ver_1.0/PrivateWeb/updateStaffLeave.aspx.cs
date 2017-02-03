using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateStaffLeave : System.Web.UI.Page
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
                string staffid = Request.QueryString["staffId"];
                string lid = Request.QueryString["qid"];
                int leaveID = Int32.Parse(lid);
                var info = db.leaves.Where(le => le.staffId == staffid && le.leaveId == leaveID).First();
                pLeave.Text = info.totalUnusedLeaveDays.ToString();
                sid.Text = info.staffId;
                sname.Text = info.name;
                daysGranted.Text = info.leaveDaysGranted.ToString();
                edate.Text = info.endDate.ToShortDateString();
                //daysLeft.Text = info.totalUnusedLeaveDays.ToString();
                dati.Text = info.startDate.ToShortDateString();
            }
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dati.Text == string.Empty)
            {
                sDati.Text = "*";
                sidL.Text = "";
                dg.Text = "";
            }
            else if (daysGranted.Text == string.Empty)
            {
                dg.Text = "*";
                sDati.Text = "";
                sidL.Text = "";
            }
           
            else if (sid.Text == string.Empty)
            {
                sidL.Text = "*";
                dg.Text = "";
                sDati.Text = "";
            }
            else
            {
                try
                {
                        string staffid = Request.QueryString["staffId"];
                        string lid = Request.QueryString["qid"];
                        int leaveID = Int32.Parse(lid);
                        var lv = db.leaves.FirstOrDefault(l => l.staffId == staffid && l.leaveId == leaveID);
                    string sd = dati.Text;
                    DateTime sdt = DateTime.Parse(sd);
                    string ed = edate.Text;
                    lv.staffId = sid.Text;
                    lv.name = sname.Text;
                    DateTime result2 = DateTime.Parse(ed);
                    //lv.comment = "what do you intend to do during your leave period?";
                    lv.leaveDaysGranted = Int32.Parse(daysGranted.Text);
                    lv.totalUnusedLeaveDays = Int32.Parse(pLeave.Text);
                    lv.startDate = sdt;
                    lv.endDate = result2;
                   // db.leaves.Add(lv);
                    db.SaveChanges();

                    var plv = db.pendingLeaves.FirstOrDefault(pl => pl.staffId == sid.Text);
                    plv.staffPendingLeave = Int32.Parse(pLeave.Text);
                    db.SaveChanges();
                    //msg.Text = "Leave Granted Successfully";
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Leave updated Successfully... click OK to continue!"")</SCRIPT>"));
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""updateLeave.aspx"") </SCRIPT>"));
                    //pLeave.Text = "";
                    //sid.Text = "";
                    //sname.Text = "";
                    //daysGranted.Text = "";
                    //edate.Text = "";
                    //daysLeft.Text = "";
                    //dati.Text = "";
                }
                catch (Exception)
                {
                    msg.Text = "Error, Updating Leave";

                }
            }
        }
    }
}