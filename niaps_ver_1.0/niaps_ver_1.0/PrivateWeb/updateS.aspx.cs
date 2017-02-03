using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateS : System.Web.UI.Page
    {
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

       
         protected void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 1;
            niapsEntities1 db = new niapsEntities1();
            StringBuilder sb = new StringBuilder();
            var result = db.qualifications.Where(st => st.staffId == filter.SelectedValue);
            sb.Append(string.Format(@"<table class=""table""><thead>
         
         <tr><td>S/No</td><td>Degree</td><td>Discipline</td><td >Institution</td><td>Date Obtained</td><td></td></tr></thead>"));

            foreach (var value2 in result)
            {
                sb.Append(string.Format(@"<tr>
                     <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td><td><a href=""updateQualification.aspx?staffId={5}&qid={6}"">update</a></td>
                </tr>
                   ", i, value2.typeOfQualification, value2.name, value2.institution, value2.dateObtained.ToShortDateString(), value2.staffId, value2.qualificationId));
                i++;
            }
            sb.Append(string.Format(@"</table>"));
            qdetail.Text = sb.ToString();
        }
    }
}