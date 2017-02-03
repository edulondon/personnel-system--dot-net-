using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateEmpRec : System.Web.UI.Page
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

        protected void emprec_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int i = 1;
            niapsEntities1 db = new niapsEntities1();
            StringBuilder sb = new StringBuilder();
            var result = db.employmentRecords.Where(st => st.staffId == emprec.SelectedValue);
            sb.Append(string.Format(@"<table class=""table""><thead>
         
         <tr><td>S/No</td><td>Company</td><td>Start Date</td><td >End Date</td><td>Post Held</td><td>Duties</td><td></td></tr></thead>"));

            foreach (var value2 in result)
            {
                sb.Append(string.Format(@"<tr>
                     <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td><td>{5}</td><td><a href=""updateEmploymentRec.aspx?Id={6}&staffId={7}"">update</a></td>
                </tr>
                   ", i, value2.company, value2.startDate.ToShortDateString(), (DateTime.Parse(value2.endDate.ToString()).ToShortDateString()), value2.postHeld, value2.duties, value2.Id, value2.staffId));
                i++;
            }
            sb.Append(string.Format(@"</table>"));
            qdetail.Text = sb.ToString();
        }
    }
}