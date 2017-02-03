using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateCurrentStaff : System.Web.UI.Page
    {
        public string getStaffId()
        {
            string sId = Request.QueryString["eid"].ToString();
            return sId;
        }
        public string getOldRecord()
        {
            niapsEntities1 db = new niapsEntities1();
            string sId = getStaffId();
            var staffRec = db.currentStaffRecords.Where(st => st.staffId == sId).First();
            string sid = staffRec.staffId;
            string id = staffRec.Id.ToString();
            string des = staffRec.designation;
            string disc = staffRec.qualification;
            string dept = staffRec.department;
            string uname = Session["fullName"].ToString();

            var message = " An update occured on Record No:" + id + " by";
            message += uname + " Initial Record: Staff Id: " + sid + ", Designation: " + des + ", Discipline:" + disc + ", Department:" + dept;
            return message;
        }
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
                niapsEntities1 db = new niapsEntities1();
                int sId = Int32.Parse(getStaffId());
                var staffRec = db.currentStaffRecords.Where(st => st.Id == sId).First();
                stid.Text = staffRec.staffId;

                dept.Text = staffRec.department;
                degree.Text = staffRec.degree;
                doj.Text = (staffRec.date_Joined).ToString();
                disc.Text = staffRec.qualification;
                doc.Text = staffRec.dateOfConfirmation.ToString();
                designation.Text = staffRec.designation;
                var ste = db.staffRecords.Where(s => s.staffId == staffRec.staffId).First();
                lname.Text = ste.lName;
                fname.Text = ste.fName;
            }

            try
            {
                niapsEntities1 db = new niapsEntities1();
                string name = Session["fullName"].ToString();
                // Insert the update transaction into the staff update history table first
                staffUpdateHistory stu = new staffUpdateHistory();
                stu.staffId = stid.Text;
                stu.updatDate = DateTime.Now;
                stu.updatedBy = name;
                string message = getOldRecord();
                // message += ": New Record: Staff Name:" + lname.Text + ", " + fname.Text + " " + mname.Text + ", Designation:" + des.Text + ",GSM: " + gsm.Text + "Email:" + email.Text + "" + ", Address" + address.Text + ", Marital Status:" + mstatus.Text + ",Status:" + status.Text;
                stu.description = message;
                db.staffUpdateHistories.Add(stu);
                db.SaveChanges();
            }
            catch (Exception)
            { }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
            string i = Request.QueryString["eid"].ToString();
            int sid = Int32.Parse(i);
            var str = db.currentStaffRecords.FirstOrDefault(ai => ai.Id == sid);
            //  DateTime result;
            str.department = dept.Text;

            str.designation = designation.Text;
            str.qualification = disc.Text;
            str.degree = degree.Text;

            db.SaveChanges();
           msg.Text = "Record updated successfully";
           // Response.Redirect("viewCurrentStaffRec.aspx?msg=" + msgs);
        }
    }
}