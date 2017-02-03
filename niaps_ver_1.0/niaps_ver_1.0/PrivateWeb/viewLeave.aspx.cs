using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class viewLeave : System.Web.UI.Page
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

            niapsEntities1 db = new niapsEntities1();
            // news ne = new news();
            var query = db.leaves.OrderBy(l => l.startDate);
            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach (var value in query)
            {
                sb.Append(string.Format(@"
                 <tr>
                        <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td><td>{5} </td>
                </tr>
                   ", count, value.name, value.leaveDaysGranted, value.startDate.ToShortDateString(), value.endDate.ToShortDateString(), value.totalUnusedLeaveDays));
                count++;
            }
            leave.Text = sb.ToString();
            
        }
        
    }
}