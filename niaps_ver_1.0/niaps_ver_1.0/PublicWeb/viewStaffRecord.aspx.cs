using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebPages;
namespace niaps_ver_1._0.PublicWeb
{
    public partial class viewStaffRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //string sId = Session["staffId"].ToString();
                string name = Session["fullName"].ToString();
                string role = Session["role"].ToString();             
            }
            catch (Exception)
            {
                Response.Redirect("../Default.aspx");
            }
            if (!IsPostBack) { getEducationalQualification(); }
            niapsEntities1 db = new niapsEntities1();
            string sId = Session["staffId"].ToString();
            string Uname = Session["uname"].ToString();
            
            // news ne = new news();
            var query = db.employmentRecords.Where(l => l.staffId == sId);
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(@" <table class = ""table""><thead><tr><td style=""font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200"">Company Name</td><td style=""font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200"">Date Employed</td><td style=""font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200"">Date Left</td><td style=""font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200"">Position Held</td><td style=""font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200"">Duties</td></tr></thead><tbody>"));
            foreach (var value in query)
            {
                sb.Append(string.Format(@"<tr>
                        <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td>
                </tr>
                   ", value.company, DateTime.Parse(value.startDate.ToString()).ToShortDateString(), DateTime.Parse(value.endDate.ToString()).ToShortDateString(), value.postHeld, value.duties));
               
            }
            per.Text = sb.ToString();
            per.Text += "</tbody></table>";
            usname.Text = Uname;
          
        }
        public List<staffRecord> GetStaffDetail()
        {
            niapsEntities1 db = new niapsEntities1();
            string sId = Session["staffId"].ToString();
            var result1 = db.staffRecords.Where(sr => sr.staffId == sId).First();
            var result2 = db.states.Where(s => s.stateCode == result1.state).First();
            int lgaCode = Int32.Parse(result1.Lga);
            var result3 = db.LGAs.Where(s3 => s3.LGACode == lgaCode).First();
            var result = db.staffRecords.Where(sr => sr.staffId == sId).ToList();
            foreach (var mc in result.Where(x => x.state == result1.state))
                mc.state = result2.state1;
            foreach (var m in result.Where(x => x.Lga == result1.Lga))
                m.Lga = result3.name;
            return result.ToList();
        }

        public List<staffNextOfKin> getNextOfKin()
        {
            niapsEntities1 db = new niapsEntities1();
            string sId = Session["staffId"].ToString();
            // string sId = Request.QueryString["staffId"].ToString();
            var result = db.staffNextOfKins.Where(sr => sr.staffId == sId).ToList();

            return result.ToList();
        }

        public List<currentStaffRecord> getCurrentEmployment()
        {
            niapsEntities1 db = new niapsEntities1();
            string sId = Session["staffId"].ToString();
            //string sId = Request.QueryString["staffId"].ToString();
            var result = db.currentStaffRecords.Where(sr => sr.staffId == sId).ToList();

            return result.ToList();
           
        }
        public void getEducationalQualification()
        {
            niapsEntities1 db2 = new niapsEntities1();
            string sid = Session["staffId"].ToString();
            int i = 1;
            var query2 = db2.qualifications.Where(l => l.staffId == sid);
            StringBuilder sb2 = new StringBuilder();
            sb2.Append(string.Format(@"<table class=""table""><tr><td style=""font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200"">S/No</td><td style=""font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200"">Degree</td><td style=""font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200"">Discipline</td><td style=""font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200"">Institution</td><td style=""font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200"">Date Obtained</td></tr>"));
            foreach (var value2 in query2)
            {
                sb2.Append(string.Format(@"
                 <tr>
                        <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td>
                </tr>
                   ", i, value2.typeOfQualification, value2.name, value2.institution, DateTime.Parse(value2.dateObtained.ToString()).ToShortDateString()));

                i++;
            }
            eq.Text = sb2.ToString();
            eq.Text += "</table>";
        }
    }
}