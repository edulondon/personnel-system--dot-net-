using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class enterStaffPendingLeave : System.Web.UI.Page
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
          
        protected void btnPLeave_Click(object sender, EventArgs e)
        {
            if (pleave.Text == string.Empty) { plError.Text = "*"; }
            try
            {
                plError.Text = "";
                string sid = sname.SelectedValue;
                var pl = db.pendingLeaves.FirstOrDefault(p => p.staffId==sid);
                pl.staffPendingLeave = Convert.ToInt32(pleave.Text);
                db.SaveChanges();
                msg.Text = "Pending Leave Updated Successfully";
            }
            catch (Exception)
            {
                plError.Text = "";
                msg.Text = "Update Failled";
            }
        }

        protected void SelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stid = sname.SelectedValue;
           // sid.Text = stid;
            var other = db.staffRecords.Where(ot => ot.staffId == stid).First();
            string firstName = other.fName;
            string middleName = other.middleName;
            string onames = firstName + " " + middleName;
            otherNames.Text = onames;
        }
    }
}