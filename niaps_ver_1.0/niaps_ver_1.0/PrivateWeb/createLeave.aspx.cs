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
    public partial class createLeave : System.Web.UI.Page
    {
        niapsEntities1 db = new niapsEntities1();
        leave lv = new leave();
        

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
                var query = from c in db.staffRecords
                            select c;
                //  SelectStaff.DataTextField = "-select-";
                SelectStaff.DataValueField = "staffId";
                SelectStaff.DataTextField = "lName";
                // SelectStaff.DataTextField = "fName";
                SelectStaff.DataSource = query.ToList();
                SelectStaff.DataBind();


            }
           

        }

        protected void SelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string staffid = SelectStaff.SelectedValue;
                // staffRecord str = new staffRecord();
                var stid = db.staffRecords.Where(c => c.staffId == staffid).First();
                sid.Text = stid.staffId;
               try{
                var sl = db.leaves.Where(s => s.staffId == staffid).First();
                DateTime ldate = sl.endDate;
                DateTime cpleave = DateTime.Now;
                if ((ldate.Year == cpleave.Year) & (ldate.Month == cpleave.Month))
                {
                    msg.Text = "staff next leave is not due";
                }               
               }catch(Exception){
                
                    string staffFulName = stid.lName + ", " + stid.middleName + " " + stid.fName;
                    sname.Text = staffFulName;
                    var cstd = db.currentStaffRecords.Where(cs => cs.staffId == stid.staffId).First();
                    string des = cstd.designation;
                    var ld = db.leaveDays.Where(l => l.designation == des).First();
                    cleave.Text = (ld.noOfLeaveDays).ToString();

                    //pendingLeave pl = new pendingLeave();
                    var staffID = db.pendingLeaves.Where(l => l.staffId == staffid).First();
                    pLeave.Text = (staffID.staffPendingLeave).ToString();
                }
         }

        protected void dobyear_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dati.Text == string.Empty)
            {
                sDati.Text = "*";
                nameL.Text = "";
                sidL.Text = "";
                dg.Text = "";
            }
            else if (daysGranted.Text == string.Empty)
            {
                dg.Text = "*";
                sDati.Text = "";
                nameL.Text = "";
                sidL.Text = "";
            }
            else if (SelectStaff.Text == string.Empty)
            {
                nameL.Text = "*";
                sidL.Text = "";
                dg.Text = "";
                sDati.Text = "";
            }
            else if (sid.Text == string.Empty)
            {
                sidL.Text = "*";
                dg.Text = "";
                sDati.Text = "";
                nameL.Text = "";
            }
            else
            {
                try
                {
                    string sd = dati.Text;
                    DateTime sdt = DateTime.Parse(sd);
                    string ed = edate.Text;
                    lv.staffId = sid.Text;
                    lv.name = sname.Text;
                    DateTime result2 = DateTime.Parse(ed);
                    lv.comment = "what do you intend to do during your leave period?";
                    lv.leaveDaysGranted = Int32.Parse(daysGranted.Text);
                    lv.totalUnusedLeaveDays = Int32.Parse(daysLeft.Text);
                    lv.startDate = sdt;
                    lv.endDate = result2;
                    db.leaves.Add(lv);
                    db.SaveChanges();

                    var plv = db.pendingLeaves.FirstOrDefault(pl => pl.staffId == sid.Text);
                    plv.staffPendingLeave = Int32.Parse(daysLeft.Text);
                    db.SaveChanges();
                    //msg.Text = "Leave Granted Successfully";
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Leave Granted Successfully... click OK to continue!"")</SCRIPT>"));
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""createLeave.aspx"") </SCRIPT>"));
                    pLeave.Text = "";
                    sid.Text = "";
                    sname.Text = "";
                    cleave.Text = "";
                    daysGranted.Text = "";
                    edate.Text = "";
                    daysLeft.Text = "";
                    dati.Text = "";
                    tldays.Text = "";
                }
                catch (Exception)
                {
                    msg.Text = "Error, Leave was not granted";

                }
            }
        }

        protected void dati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int leaveDaysGranteds = Int32.Parse(daysGranted.Text);
            string sd = dati.Text;
            DateTime result = DateTime.Parse(sd);
            int currentLeaveDays = Int32.Parse(cleave.Text);
            int unusedleaveDays = Int32.Parse(pLeave.Text);
            int leaveDaysGranted = Int32.Parse(daysGranted.Text);

            int totalLeaveDays = currentLeaveDays + unusedleaveDays;
            daysLeft.Text = (totalLeaveDays - leaveDaysGranted).ToString();

            tldays.Text = totalLeaveDays.ToString(); //staff total leave days.

            int myDay = result.Day;
            int myYear = result.Year;
            int myMonth = result.Month;
            if ((myDay + totalLeaveDays) > DateTime.DaysInMonth(myYear, myMonth))
            {
                myDay = (myDay + totalLeaveDays) - DateTime.DaysInMonth(myYear, myMonth);
                if (myMonth >= 12)
                {
                    myMonth = 1;
                    myYear += 1;
                }
                else
                {
                    myMonth += 1;
                }
                if (myDay > DateTime.DaysInMonth(myYear, myMonth))
                {
                            myDay = myDay - DateTime.DaysInMonth(myYear, myMonth);
                            if (myMonth >= 12)
                            {
                                myMonth = 1;
                                myYear += 1;
                            }
                            else
                            {
                                myMonth += 1;
                            }
                        }
                    }
                    else
                    {
                        myDay = myDay + totalLeaveDays;
                    }

            edate.Text = myMonth + "/" + myDay + "/" + myYear;

            }
            catch (Exception)
            {
                sDati.Text = "invalid date";
                // msg.Text += exc.Message;
            }    
       }


        protected void daysGranted_TextChanged(object sender, EventArgs e)
        {
            dg.Text = "";
            try
            {
                if (char.IsNumber(daysGranted.Text, 0))
                {

                }
                else
                {
                    dg.Text = "enter number";

                }
            }
            catch (Exception) { dg.Text = "enter number"; }
        }
    }
}