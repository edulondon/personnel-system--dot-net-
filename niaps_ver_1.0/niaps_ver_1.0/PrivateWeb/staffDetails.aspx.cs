using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class staffDetails : System.Web.UI.Page
    {
        private niapsEntities1 db = new niapsEntities1();

        protected void Page_Load(object sender, EventArgs e)
        {
           string sId = Request.QueryString["staffId"].ToString();
            try
            {
                string name = Session["fullName"].ToString();
                string role = Session["role"].ToString();
            }
            catch (Exception)
            {
                Response.Redirect("../Default.aspx");
            }
          
            try
            {
                var query = db.employmentRecords.Where(l => l.staffId == sId);
                StringBuilder sb = new StringBuilder();
                per.Text = string.Format(@"<table class=""table""><tr>
                    <th colspan=""4""><asp:Image ID=""Image2"" runat=""server"" ImageUrl=""~/images/Heading_personal_details.jpg"" Height=""19px"" Width=""557px""/></th></tr><tr><td>Company Name</td><td>Date Employed</td><td>Date Left</td><td>Position Held</td><td>Duties</td></tr>");
                foreach (var value in query)
                {
                    sb.Append(string.Format(@"
                 <tr>
                        <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td>
                </tr>
                   ", value.company, value.startDate.ToShortDateString(), value.endDate, value.postHeld, value.duties));
                    
                }
                per.Text += sb.ToString();
                per.Text += "</table>";
            }catch(Exception){
                pMsg.Text = "data not found";
                
            }
            try
            {
                int i = 1;
                var query2 = db.qualifications.Where(l => l.staffId == sId);
                StringBuilder sb2 = new StringBuilder();
                eq.Text = string.Format(@"<table class=""table""><tr><td>S/No</td><td>Discipline</td><td>Institution</td><td>Date Obtained</td><td>Degree</td></tr>");
                foreach (var value2 in query2)
                {
                    sb2.Append(string.Format(@"
                 <tr>
                        <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td>
                </tr>
                   ", i, value2.name, value2.institution, value2.dateObtained.ToShortDateString(), value2.typeOfQualification));
                    
                    i++;
                }
                eq.Text += sb2.ToString();
                eq.Text += "</table>";
            }
            catch (Exception)
            {
                eMsg.Text = "data not found";
               // eMsg.Text += x.Message;
            }
        }
        //public List<qualification> GetQualificationDetail()
        //{

        //    string sId = Request.QueryString["staffId"].ToString();
        //    var result = db.qualifications.Where(l => l.staffId == sId).ToList();

        //    return result.ToList();
        //}
        public List<staffRecord> GetStaffDetail()
        {

            string sId = Request.QueryString["staffId"].ToString();
            var result1 = db.staffRecords.Where(sr => sr.staffId == sId).First();
            var result2 = db.states.Where(s=>s.stateCode==result1.state).First();
            int lgaCode = Int32.Parse(result1.Lga);
            var result3 = db.LGAs.Where(s3 => s3.LGACode ==lgaCode).First();
            var result = db.staffRecords.Where(sr => sr.staffId == sId).ToList();
            foreach (var mc in result.Where(x => x.state == result1.state))
                mc.state = result2.state1;
            foreach (var m in result.Where(x => x.Lga == result1.Lga))
                m.Lga = result3.name;
            return result.ToList();
        }

        public List<staffNextOfKin> getNextOfKin()
        {

            string sId = Request.QueryString["staffId"].ToString();
            var result = db.staffNextOfKins.Where(sr => sr.staffId == sId).ToList();

            return result.ToList();
        }

        public List<currentStaffRecord> getCurrentEmployment()
        {

            string sId = Request.QueryString["staffId"].ToString();
            var result = db.currentStaffRecords.Where(sr => sr.staffId == sId).ToList();

            return result.ToList();
        
        }
    }
}