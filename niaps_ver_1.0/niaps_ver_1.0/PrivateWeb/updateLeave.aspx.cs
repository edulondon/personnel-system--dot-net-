using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateLeave : System.Web.UI.Page
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
           
            niapsEntities1 db = new niapsEntities1();
            StringBuilder sb = new StringBuilder();
            var result = db.leaves.Where(st => st.staffId == filter.SelectedValue);
            sb.Append(string.Format(@"<table class=""table""><thead>
         
         <tr><td>Staff Id</td><td>Name</td><td>Leave Start Date</td><td>Leave End Date</td><td></td></tr></thead>"));

            foreach (var value2 in result)
            {
                sb.Append(string.Format(@"<tr>
                     <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td><a href=""updateStaffLeave.aspx?staffId={4}&qid={5}"">update</a></td>
                </tr>
                   ", value2.staffId, value2.name, value2.startDate.ToShortDateString(), value2.endDate.ToShortDateString(), value2.staffId, value2.leaveId));
                
            }
            sb.Append(string.Format(@"</table>"));
            qdetail.Text = sb.ToString();
        }
    }
}