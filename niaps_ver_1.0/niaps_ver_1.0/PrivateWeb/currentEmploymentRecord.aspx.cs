using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class currentEmploymentRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            niapsEntities1 db = new niapsEntities1();
            string sId = Request.QueryString["staffId"].ToString();
            sid.Text = sId;
            var sn = db.staffRecords.Where(n => n.staffId == sId).First();
            string ln = sn.lName;
            string fn = sn.fName;
            sname.Text = ln+", "+fn;
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

        protected void create_Click(object sender, EventArgs e)
        {
            try
            {
                niapsEntities1 db = new niapsEntities1();
                currentStaffRecord cst = new currentStaffRecord();
                cst.staffId = sid.Text;
                cst.designation = designation.Text;
                cst.department = dept.Text;
                cst.qualification = qualification.Text;
                string djDay = doeday.Text;
                string djMonth = doemonth.Text;
                string djYear = doeyear.Text;
                string dateJoined = djDay + "-" + djMonth + "-" + djYear;
                CultureInfo provider = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = provider;
                cst.date_Joined = DateTime.Parse(dateJoined);
                cst.degree = degree.Text;
                
                cst.probationPeriod = Int32.Parse(pperiod.Text);
                cst.dateOfConfirmation = DateTime.Parse(confirm.Text);
                db.currentStaffRecords.Add(cst);
                db.SaveChanges();
               // db.Dispose();
                string message = "Registration Completed Successfully";
                Response.Redirect("message.aspx?msg=" + message);
            }
            catch(Exception ex)
            {
                msg.Text = "Error creating Current Employment Records";
                msg.Text += ex;
            }
        }

        protected void pperiod_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStaffRecord cst = new currentStaffRecord();
            int probationPeriod = Int32.Parse(pperiod.Text);
            string djDay = doeday.Text;
            string djMonth = doemonth.Text;
            string djYear = doeyear.Text;
            string dateJoined = djDay + "-" + djMonth + "-" + djYear;
            CultureInfo provider = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = provider;
            DateTime date_Joined = DateTime.Parse(dateJoined);
            int newMonth= (date_Joined.Month + probationPeriod);
            if (newMonth >= 12)
            {
                newMonth = newMonth - 12;
                int newYear = Int32.Parse(doeyear.Text) + 1;
                confirm.Text = djDay + "-" + newMonth + "-" + newYear;
            }
            else
            {
                confirm.Text = newMonth + "-" + djDay + "-" + djYear;
            }
        }
    }
}