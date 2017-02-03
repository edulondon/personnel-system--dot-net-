using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Globalization;
namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateStaff : System.Web.UI.Page
    {
       public string getStaffId()
        {
            string sId = Request.QueryString["staffId"].ToString();
            return sId;
        }
        public string getOldRecord() {
            niapsEntities1 db = new niapsEntities1();
            string sId = getStaffId();
            var staffRec = db.staffRecords.Where(st => st.staffId == sId).First();
            string sid= staffRec.staffId;
           // string lname= staffRec.lName;
            string fname= staffRec.fName;
           // string gender = staffRec.gender;
           // string dob= staffRec.dateOfBirth.ToShortDateString();
            string mname = staffRec.middleName;
           // string des = staffRec.designation;
           // string age=staffRec.age.ToString();
            string gsm= staffRec.mobile;
            string address = staffRec.address;
            string email = staffRec.email;
           string  mstatus = staffRec.marritalStatus;
         //  string  foid = staffRec.formOfIdentification;
          // string  idNumber = staffRec.idNumber;
          // string  edate = staffRec.dateOfEmployment.ToShortDateString();
           string  status = staffRec.status;

           string uname = Session["fullName"].ToString();
           var message = " An update occured on Staff No:&nbsp;&nbsp;" + sid + " by&nbsp;&nbsp;&nbsp;";
           message += uname + " Initial Record: First Name:&nbsp;&nbsp; " + fname + ", Middle Name: " + mname + ", GSM:" + gsm + ", Address:" + address + ", Email:" + email + ", Status: " + status + ", Marital Status: " + mstatus;
            db.Dispose();
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
                string sId = getStaffId();
                var staffRec = db.staffRecords.Where(st => st.staffId == sId).First();
                stid.Text = staffRec.staffId;
                lname.Text = staffRec.lName;
                fname.Text = staffRec.fName;
                gender.Text = staffRec.gender;
                dob.Text = staffRec.dateOfBirth.ToShortDateString();
                mname.Text = staffRec.middleName;
                // des.Text = staffRec.designation;
                age.Text = staffRec.age.ToString();
                gsm.Text = staffRec.mobile;
                int lcode = Int32.Parse(staffRec.Lga);
                var lg = db.LGAs.Where(l => l.LGACode == lcode).First();
                lga.Text = lg.name;

                string scode = staffRec.state;
                var ste = db.states.Where(s => s.stateCode == scode).First();
                state.Text = ste.state1;
                address.Text = staffRec.address;
                email.Text = staffRec.email;
                mstatus.Text = staffRec.marritalStatus;
                foid.Text = staffRec.formOfIdentification;
                idNumber.Text = staffRec.idNumber;

                try
                {
                    var nkin = db.staffNextOfKins.Where(nk => nk.staffId == sId).First();
                    kinLastName.Text = nkin.lname;
                    kinFirstName.Text = nkin.fName;
                    kinAddress.Text = nkin.address;
                    kinGender.Text = nkin.gender;
                    kinGsm.Text = nkin.contactMobile;
                    relationship.Text = nkin.relationship;

                    var emp = db.currentStaffRecords.Where(em => em.staffId == sId).First();
                   designation.Text = emp.designation;
                    degree.Text = emp.degree;
                    disc.Text = emp.qualification;
                    djoined.Text = DateTime.Parse(emp.date_Joined.ToString()).ToShortDateString();
                    dc.Text = DateTime.Parse(emp.dateOfConfirmation.ToString()).ToShortDateString();
                    pbp.Text = emp.probationPeriod.ToString();
                    dept.Text = emp.department;
                    //db.Dispose();
                }
                catch (Exception ex)
                {
                    msg.Text = ex.Message;
                }
            }
        }
        protected void update_Click(object sender, EventArgs e)
        {
            try
            {
                niapsEntities1 db = new niapsEntities1();
                string uname = Session["fullName"].ToString();
                staffUpdateHistory stu = new staffUpdateHistory();
                stu.staffId = stid.Text;
                stu.updatDate = DateTime.Now;
                stu.updatedBy = uname;
                string message = getOldRecord();
                stu.description = message;
                db.staffUpdateHistories.Add(stu);
                db.SaveChanges();
                niapsEntities1 db2 = new niapsEntities1();
                string sid = stid.Text;
                var str = db2.staffRecords.FirstOrDefault(ai => ai.staffId == sid);
                // str.staffId = sid;
                str.lName = lname.Text;
                str.fName = fname.Text;
                str.gender = gender.Text;
                string date1 = dob.Text;
                DateTime dobirth = DateTime.Parse(date1);
                str.dateOfBirth = dobirth;
                str.middleName = mname.Text;
                // str.designation = des.Text;
                str.age = Int32.Parse(age.Text);
                str.mobile = gsm.Text;

                var lg = db.LGAs.Where(l => l.name == lga.Text).First();
                string loc = lg.LGACode.ToString();
                str.Lga = loc;

                var ste = db.states.Where(s => s.state1 == state.Text).First();

                str.state = ste.stateCode;
                str.address = address.Text;
                str.email = email.Text;
                str.marritalStatus = mstatus.Text;
                str.formOfIdentification = foid.Text;
                str.idNumber = idNumber.Text;
                db2.SaveChanges();

                niapsEntities1 db3 = new niapsEntities1();
                string sId = Request.QueryString["staffId"].ToString();
                var kin = db3.staffNextOfKins.FirstOrDefault(ki => ki.staffId == sId);
                kin.lname = kinLastName.Text;
                kin.fName = kinFirstName.Text;
                kin.address = kinAddress.Text;
                kin.gender = kinGender.Text;
                kin.contactMobile = kinGsm.Text;
                kin.relationship = relationship.Text;
                db3.SaveChanges();

                niapsEntities1 db4 = new niapsEntities1();
                var empl = db4.currentStaffRecords.FirstOrDefault(emp => emp.staffId == sId);
                empl.degree = degree.Text;
                empl.designation = designation.Text;
                empl.qualification = disc.Text;
                empl.dateOfConfirmation = DateTime.Parse(dc.Text);
                empl.date_Joined = DateTime.Parse(djoined.Text);
                empl.probationPeriod = Int32.Parse(pbp.Text);
                empl.department = dept.Text;
                db4.SaveChanges();
               
                stid.Text = "";
                lname.Text = "";
                fname.Text = "";
                gender.Text = "";
                dob.Text = "";
                mname.Text = "";
                age.Text = "";
                gsm.Text = "";

                lga.Text = "";

                state.Text = "";
                address.Text = "";
                email.Text = "";
                mstatus.Text = "";
                foid.Text = "";
                idNumber.Text = "";

                kinLastName.Text = "";
                kinFirstName.Text = "";
                kinAddress.Text = "";
                kinGender.Text = "";
                kinGsm.Text = "";
                relationship.Text = "";
               degree.Text = "";
                designation.Text = "";
               disc.Text = "";
                dc.Text = "";
               djoined.Text = "";
               pbp.Text = "";

                msg.Text = "staff updated successfully";
            }
            catch (Exception)
            {
                msg.Text = "error occured! could not update";
            }
        }

    }
}