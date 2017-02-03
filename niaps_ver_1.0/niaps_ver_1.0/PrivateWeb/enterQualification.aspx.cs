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
    public partial class enterQualification : System.Web.UI.Page
    {
        public niapsEntities1 db = new niapsEntities1();

        protected void Page_Load(object sender, EventArgs e)
        {
            string sId = Request.QueryString["staffId"].ToString();
           // string staffName = Request.QueryString["name"].ToString();
            sid.Text = sId;
           // sname.Text = staffName;
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
            try{

            qualification qu = new qualification();
            
            qu.staffId = sid.Text;
            qu.name = basicQ.Text;
            string day = qday.Text;
            string month = qmonth.Text;
            string year = qyear.Text;
            string result = day +"-"+ month +"-"+ year;
            CultureInfo provider = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = provider;
            DateTime dateo = DateTime.Parse(result);
            qu.dateObtained = dateo;
            qu.typeOfQualification = degree.Text;
            qu.institution = inst.Text;
            db.qualifications.Add(qu);
             db.SaveChanges();
             Response.Redirect("enterEmploymentRecord.aspx?staffId=" + sid.Text);
            
            }
            catch(Exception ex)
            {
                msg.Text = ex.Message;
            }
        }

        protected void sname_SelectedIndexChanged(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
            string stid = sname.SelectedValue;
            sid.Text = stid;
            var other = db.staffRecords.Where(ot => ot.staffId == stid).First();
            string firstName = other.fName;
            string middleName = other.middleName;
            string onames = firstName + " " + middleName;
            otherNames.Text = onames;
        }

       
    }
}