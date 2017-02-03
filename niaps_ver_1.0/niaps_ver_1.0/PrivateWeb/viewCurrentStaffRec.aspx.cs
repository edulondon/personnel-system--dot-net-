using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class viewCurrentStaffRec : System.Web.UI.Page
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

            var query = db.currentStaffRecords;
            StringBuilder sb = new StringBuilder();
            foreach (var value in query)
            {
                sb.Append(string.Format(@"
                 <tr>
                       <td> {0}</td><td>{1} </td><td> {2}</td><td> {3}</td><td> {4}</td><td> {5}</td><td> {6}</td><td><a href=""updateCurrentStaff.aspx?eid={7}"">update</a></td>
                </tr>
                   ", value.staffId, value.designation, value.department, value.degree, value.qualification, value.date_Joined, value.dateOfConfirmation, value.Id));
                qst.Text += sb.ToString();
            }
            
        }
    }
}