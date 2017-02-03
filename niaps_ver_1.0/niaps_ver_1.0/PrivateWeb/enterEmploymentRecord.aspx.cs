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
    public partial class enterEmploymentRecord : System.Web.UI.Page
    {
        public niapsEntities1 db = new niapsEntities1();

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
            string sId = Request.QueryString["staffId"].ToString();
            string lastName = Request.QueryString["lname"].ToString();
            string firstName = Request.QueryString["fname"].ToString();
            string middleName = Request.QueryString["mname"].ToString();
            stid.Text = sId;
            staffName.Text = lastName + ", " + firstName + " " + middleName;

           
        }


        protected void create_Click1(object sender, EventArgs e)
        {
            if (designation.Text.Equals("-select-"))
                {
                    deptError.Text = "";
                    dopError.Text = "";
                    msg.Text = "select staff designation";
                }
                if (dept.Text == string.Empty)
                {
                    deptError.Text = "*";
                    dopError.Text = "";
                    msg.Text = "";
                }
                if (dtEmp.Text==string.Empty)
                {
                    dopError.Text = "*";
                    msg.Text = "";
                    deptError.Text = "";
                }
                
            try
            {
                employmentRecord er = new employmentRecord();
                if ((cname.Text == string.Empty) && (pheld.Text == string.Empty) && (duties.Text == string.Empty))
                {
                    msg.Text = "enter at least one previous company record";
                }
                else {
                    er.staffId = stid.Text;
                    er.company = cname.Text;
                   
                    string dateString = dj1.Text;
                    CultureInfo provider = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentCulture = provider;
                    DateTime sd = DateTime.Parse(dateString);
                    er.startDate = sd;
                    
                    string dateString1 = dl1.Text ;
                    DateTime ed = DateTime.Parse(dateString1);
                    er.endDate = ed;
                    er.postHeld = pheld.Text;
                    er.duties = duties.Text;
                    db.employmentRecords.Add(er);
                    db.SaveChanges();
                }
                if (cname0.Text != string.Empty)
                {
                    er.staffId = stid.Text;
                    er.company = cname0.Text;
                    string dateString = dj2.Text;
                    DateTime sd = DateTime.Parse(dateString);
                    er.startDate = sd;
                    DateTime ed = DateTime.Parse(dl2.Text);
                    er.endDate = ed;
                    er.postHeld = pheld0.Text;
                    er.duties = duties0.Text;
                    db.employmentRecords.Add(er);
                    db.SaveChanges();
                }
                if (cname1.Text != string.Empty)
                {
                    er.staffId = stid.Text;
                    er.company = cname1.Text;
                    string dateString = dj3.Text;
                    DateTime sd = DateTime.Parse(dateString);
                    er.startDate = sd;
                    DateTime ed = DateTime.Parse(dl3.Text);
                    er.endDate = ed;
                    er.postHeld = pheld1.Text;
                    er.duties = duties1.Text;
                    db.employmentRecords.Add(er);
                    db.SaveChanges();
                }
                

            }
            catch (Exception ex)
            {
                msg.Text = ex.Message;
            }
            try
            {

                currentStaffRecord cst = new currentStaffRecord();
                
                    cst.staffId = stid.Text;
                    cst.designation = designation.Text;
                    cst.department = dept.Text;
                    cst.qualification =  Request.QueryString["bq"].ToString();
                    CultureInfo provider = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentCulture = provider;
                    cst.date_Joined = DateTime.Parse(dtEmp.Text);
                    cst.degree = Request.QueryString["degree"].ToString();
                    cst.probationPeriod = Int32.Parse(pperiod.Text);
                    string conDate = confirm.Text;
                    cst.dateOfConfirmation = DateTime.Parse(conDate);
                    db.currentStaffRecords.Add(cst);
                    db.SaveChanges();
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Registration Completed Successfully... click OK to continue!"")</SCRIPT>"));
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""createStaff.aspx"") </SCRIPT>"));
                    
                   // Response.Redirect("createStaff.aspx");
                }
            
            catch (Exception)
            {
               // stid.Text = "";
                cname.Text = "";
                dj1.Text = "";
                dl1.Text = "";
                pheld.Text = "";
                duties.Text = "";
                designation.Text = "-select-";
                dept.Text = "";
                dtEmp.Text = "";
                deptError.Text = "";
                dopError.Text = "";
                msg.Text = "Error creating Current Employment Records";
              
            }
        }

        protected void pperiod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void dl1_TextChanged(object sender, EventArgs e)
        {
            if (dl1.Text==string.Empty)
            {
                dateError.Text = "*";
            }
            else
            {
                try
                {
                    DateTime dateJoined = DateTime.Parse(dj1.Text);
                    DateTime dateLeft =  DateTime.Parse(dl1.Text);
                    DateTime datePresentYear = DateTime.Now; // for comparing presend year of employment date and date left previous work
                    DateTime doemp = DateTime.Parse(dtEmp.Text);
                    int dateJY =  dateJoined.Year;
                    int dateLY = dateLeft.Year;
                    int datePY = datePresentYear.Year;
                    if (dateJY > dateLY)
                    {
                        
                        dateError.Text = "*";
                        dl1.Text = "";
                    }
                    else if (dateLY > datePY) { dateError.Text = "*"; dl1.Text = ""; }
                    else if (dateLY > doemp.Year) { dateError.Text = "*"; dl1.Text = ""; }
                }
                catch (Exception)
                {
                    dateError.Text = "*";
                    dl1.Text = "";
                }
            }
        }

        protected void dl2_TextChanged(object sender, EventArgs e)
        {
            dateError2.Text = "";
            if (dl2.Text==string.Empty)
            {
                dateError2.Text = "*";
            }
            else
            {
                try
                {
                    dateError.Text = "";
                    dateError2.Text = "";
                    DateTime dateJoined2 = DateTime.Parse(dj2.Text);
                    DateTime dateLeft2 = DateTime.Parse(dl2.Text);
                    DateTime datePresentYear2 = DateTime.Now; // for comparing presend year of employment date and date left previous work
                    DateTime dateLeft = DateTime.Parse(dl1.Text); // for comparing date left first work and second work
                    DateTime doemp = DateTime.Parse(dtEmp.Text);
                    int dateJY2 = dateJoined2.Year;
                    int dateLY2 = dateLeft2.Year;
                    int datePY2= datePresentYear2.Year;
                    int dateLY = dateLeft.Year;
                    if (dateJY2 > dateLY2)
                    {
                        dateError2.Text = "*";
                    }
                    else if (dateLY2 > datePY2) { dateError2.Text = "*"; dl2.Text = ""; }
                    else if (dateLY < dateJY2) { dateError2.Text = "*"; dl2.Text = ""; }
                    else if (dateLY2 > doemp.Year) { dateError2.Text = "*"; dl2.Text = ""; }
                }
                catch (Exception)
                {
                    dateError2.Text = "*";
                    dl2.Text = "";
                }
            }
        }

        protected void dl3_TextChanged(object sender, EventArgs e)
        {
            dateError3.Text = "";
            if (dl2.Text == string.Empty)
            {
                dateError3.Text = "*";
            }
            else
            {
                try
                {
                    dateError.Text = "";
                    dateError2.Text = "";
                    dateError3.Text = "";
                    dopError.Text = "*";
                    DateTime dateJoined3 = DateTime.Parse(dj3.Text);
                    DateTime dateLeft3 = DateTime.Parse(dl3.Text);
                    DateTime datePresentYear3 = DateTime.Now; // for comparing presend year of employment date and date left previous work
                    DateTime dateLeft = DateTime.Parse(dl1.Text); // for comparing date left first work and third work
                    DateTime dateLeft2 = DateTime.Parse(dl2.Text);// for comparing date left second work and third work
                    DateTime doemp = DateTime.Parse(dtEmp.Text);
                    int dateJY3 = dateJoined3.Year;
                    int dateLY3 = dateLeft3.Year;
                    int datePY3 = datePresentYear3.Year;
                    int dateLY = dateLeft.Year;
                    int dateLY2 = dateLeft2.Year;
                    if (dateJY3 > dateLY3)
                    {
                        dateError3.Text = "*";
                    }
                    if (dateLY3 > datePY3) { dateError3.Text = "*"; dl3.Text = ""; }
                    if (dateLY < dateJY3) { dateError3.Text = "*"; dl3.Text = ""; }
                    if (dateLY3 > doemp.Year) { dateError3.Text = "*"; dl3.Text = ""; }
                }
                catch (Exception)
                {
                    dateError3.Text = "*";
                    dl3.Text = "";
                }
            }
        }

        protected void pperiod_SelectedIndexChanged1(object sender, EventArgs e)
        {
             try
             {
                 if (pperiod.Text == string.Empty)
                 {
                     perror.Text = "*";
                 }
                 else
                 {
                     confirm.Text = "";
                     int probationPeriod = Int32.Parse(pperiod.Text);

                     string dps = "";
                     dps = dtEmp.Text;
                     CultureInfo provider = new CultureInfo("en-US");
                     Thread.CurrentThread.CurrentCulture = provider;
                     DateTime date_Joined = DateTime.Parse(dps);
                     int newMonth = (date_Joined.Month + probationPeriod);
                     if (newMonth > 12)
                     {
                         newMonth = newMonth - 12;

                         int newYear = (date_Joined.Year) + 1;
                         confirm.Text += newMonth + "/" + date_Joined.Day + "/" + newYear;
                     }
                     else
                     {

                         confirm.Text = newMonth + "/" + date_Joined.Day + "/" + date_Joined.Year;
                     }
                 }
             }
             catch (Exception ex)
             {
                 msg.Text = ex.Message;
             }
        }

        protected void dj1_TextChanged(object sender, EventArgs e)
        {
            if (dj1.Text == string.Empty)
            {
                dj1Error.Text = "*";
                dj1.Text = "";
            }
            try
            {
                dj1Error.Text = "";
                string d = dtEmp.Text;
            string d2 = dj1.Text;
            CultureInfo provider = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = provider;
            DateTime dateDj1 = DateTime.Parse(d2);
            DateTime dateEmp = DateTime.Parse(d);
            int dj1Com = dateDj1.Year;
            int empCom = dateEmp.Year;
            if (dj1Com > empCom)
            {
                dj1Error.Text = "invalid date";
            }
            }
            catch (Exception)
            {
                dj1Error.Text = "*";
                dj1.Text = "";
            }
        }

        protected void dj2_TextChanged(object sender, EventArgs e)
        {
            if (dj2.Text == string.Empty)
            {
                dj2Error.Text = "*";
                dj2.Text = "";
            }
            try
            {
                dj2Error.Text = "";
                string d = dj1.Text;
                string d2 = dj2.Text;
                CultureInfo provider = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = provider;
                DateTime dateDj1 = DateTime.Parse(d);
                DateTime dateDj2 = DateTime.Parse(d2);
                int dj1Com = dateDj1.Year;
                int dj2Com = dateDj2.Year;
                if (dj1Com < dj2Com)
                {
                    dj2Error.Text = "invalid date";
                }
            }
            catch (Exception)
            {
                dj2Error.Text = "*";
                dj2.Text = "";
            }
        }

        protected void dtEmp_TextChanged(object sender, EventArgs e)
        {
            if (dtEmp.Text == string.Empty)
            {
                dopError.Text = "*";
                dateError3.Text = "";
                dtEmp.Text = "";
            }
            try
            {
                dopError.Text = "";
                string d = dtEmp.Text;
                // string d2 = dates.Text;
                CultureInfo provider = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = provider;
                DateTime dateEmp = DateTime.Parse(d);
                DateTime datePresentYear2 = DateTime.Now;
                if ((dateEmp.Year >= datePresentYear2.Year)&&(dateEmp.Month > datePresentYear2.Month))
                {
                    dopError.Text = "*";
                    dateError3.Text = "";
                    dtEmp.Text = "";
                }
            }
            catch (Exception)
            {
                dopError.Text = "*";
                dateError3.Text = "";
                dtEmp.Text = "";
            }
        }

      }
}