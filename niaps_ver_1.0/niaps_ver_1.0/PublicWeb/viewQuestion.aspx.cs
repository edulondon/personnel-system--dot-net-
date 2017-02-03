using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class viewQuestion : System.Web.UI.Page
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

            var query = db.questions;
            StringBuilder sb = new StringBuilder();
            foreach (var value in query)
            {
                sb.Append(string.Format(@"
                 <tr>
                       <td> {0}</td><td>{1} </td><td><a href=""updateQuestion.aspx?qid={2}"">edit</a></td>
                </tr>
                   ", value.qstId, value.question1, value.id));
                qst.Text += sb.ToString();
            }
            
        }
    }
}