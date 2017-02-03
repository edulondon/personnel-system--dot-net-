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
    public partial class furtherQualification : System.Web.UI.Page
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
        }

        protected void sname_SelectedIndexChanged(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
            string stid = sname.SelectedValue;
            var other = db.staffRecords.Where(ot => ot.staffId == stid).First();
            string firstName = other.fName;
            string middleName = other.middleName;
            string onames = firstName + "&nbsp;&nbsp; " + middleName + " &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; Id: " + stid;
            otherNames.Text = onames;
            var bqtn = db.currentStaffRecords.Where(qt => qt.staffId == stid).First();
            bq.Text = bqtn.degree + ".  " + bqtn.qualification;
        }

        protected void create_Click(object sender, EventArgs e)
        {
            if (basicQ.Text.Equals("") || basicQ.Text.Equals(null))
            {
                bqError.Text = "*";
            }
            if (degree.Text.Equals("-select-") || degree.Text.Equals(null))
            {
                degreeError.Text = "*";
            }
            if ((dateO.Text.Equals("") || dateO.Text.Equals(null)))
            {
                dateError.Text = "*";
            }
            if (inst.Text.Equals("") || inst.Text.Equals(null))
            {
                instError.Text = "*";
            }
            if (sname.Text.Equals("") || sname.Text.Equals(null))
            {
                snameError.Text = "*";
            }


            try
            {

                qualification qu = new qualification();
                string stid = sname.SelectedValue;
                qu.staffId = stid;
                qu.name = basicQ.Text;
                string result = dateO.Text;
                CultureInfo provider = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = provider;
                DateTime dateo = DateTime.Parse(result);
                qu.dateObtained = dateo;
                qu.typeOfQualification = degree.Text;
                qu.institution = inst.Text;
                db.qualifications.Add(qu);
                db.SaveChanges();
               

             //  msg.Text = "Additional Qualification created Successfully";
               System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Additional Qualification created Successfully... click OK to continue!"")</SCRIPT>"));
               System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""furtherQualification.aspx"") </SCRIPT>"));
                 bqError.Text = "";
                degreeError.Text = "";
                dateError.Text = "";
                instError.Text = "";
                snameError.Text = "";
                degree.Text = "-select-";
                inst.Text = "";
                basicQ.Text = "";
                dateO.Text = "";
                
            //   Response.Redirect("furtherQualification.aspx");
            }
            catch (Exception)
            {
                msg.Text = "Could not create Additional Qualification";
            }
        }

        protected void dateO_TextChanged(object sender, EventArgs e)
        {
            dateError.Text = "";
            DateTime dateEmp = DateTime.Parse(dateO.Text);
            DateTime datePresentYear2 = DateTime.Now;
            if ((dateEmp.Year > datePresentYear2.Year) & (dateEmp.Month > datePresentYear2.Month) & (dateEmp.Day > datePresentYear2.Day))
            {
                dateError.Text = "*";
                dateO.Text = "";
            }      
        }
    }
}