using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateQualification : System.Web.UI.Page
    {
        private niapsEntities1 db = new niapsEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string sId = Request.QueryString["staffId"].ToString();

            }
            catch(Exception) {
                Response.Redirect("updateS.aspx");
            }
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
                 try
                 {
                     string sId = Request.QueryString["staffId"].ToString();
                     int qid = Int32.Parse(Request.QueryString["qid"].ToString());
                     var emp = db.qualifications.Where(em => em.staffId == sId && em.qualificationId == qid).First();
                     inst.Text = emp.institution;
                     degree.Text = emp.typeOfQualification;
                     bq.Text = emp.name;
                     dobt.Text = DateTime.Parse(emp.dateObtained.ToString()).ToShortDateString();

                     var staffRec = db.staffRecords.Where(st => st.staffId == sId).First();
                     string sid = staffRec.staffId;
                     string fname = staffRec.fName;
                     string mname = staffRec.middleName;
                     sname.Text = staffRec.lName + ", " + fname + "  " + mname + "      Id    " + sid + "         Date Obtained "+ emp.dateObtained;
                 }
                 catch (Exception)
                 {
                     msg.Text = "error reading data";
                 }
             }
        }

        protected void update_Click(object sender, EventArgs e)
        {

            try
            {
                int qid = Int32.Parse(Request.QueryString["qid"].ToString());
                var ufq = db.qualifications.FirstOrDefault(uf => uf.qualificationId == qid);
                ufq.institution = inst.Text;
                ufq.dateObtained = DateTime.Parse(dobt.Text);
                ufq.typeOfQualification = degree.Text;
                ufq.name = bq.Text;
                db.SaveChanges();

                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""updated Successfully... click OK to continue!"") </SCRIPT>"));
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""updateS.aspx"") </SCRIPT>"));

                sname.Text = "";
                inst.Text = "";
                dobt.Text = "";
                degree.Text = "";
                bq.Text = "";
            }
            catch (Exception)
            {
                msg.Text = "update failed";
            }
            //Response.Redirect("updateS.aspx");
        }
    }
}