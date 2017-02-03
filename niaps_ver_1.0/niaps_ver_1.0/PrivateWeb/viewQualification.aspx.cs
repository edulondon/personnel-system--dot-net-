using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class viewQualification : System.Web.UI.Page
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

            var query = db.qualifications;
            StringBuilder sb = new StringBuilder();
            foreach (var value in query)
            {
                sb.Append(string.Format(@"
                 <tr>
                       <td> {0}</td><td>{1} </td><td> {2}</td><td> {3}</td><td> {4}</td><td><a href=""updateQualification.aspx?qid={5}"">update</a></td>
                </tr>
                   ", value.staffId, value.typeOfQualification, value.name, value.institution, value.dateObtained, value.qualificationId));
                qst.Text += sb.ToString();
            }
            
        }
    }
}