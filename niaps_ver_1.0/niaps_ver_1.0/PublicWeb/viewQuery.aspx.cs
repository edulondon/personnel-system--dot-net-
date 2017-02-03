using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class viewQuery : System.Web.UI.Page
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
            string sId = Session["staffId"].ToString();
            var query = db.queries.Where(l => l.staffId == sId);
            StringBuilder sb = new StringBuilder();
            int i = 1;
            foreach (var value in query)
            {
                if (value.reply==null)
                {
                    sb.Append(string.Format(@"
                 <tr>
                   <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td><td>{5} </td><td>{6}</td><td>{7}</td><td> <a href=""query.aspx?qId={8}"">answer</a> </td>
                </tr>
                   ", i, value.natureOfQuery, value.issuedBy, value.dateIssued.ToShortDateString(), value.reply, value.dateReplied, value.actionTaken, value.disciplinaryEffectDate, value.Id));
                }
                else {
                    sb.Append(string.Format(@"
                 <tr>
                   <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td><td>{5} </td><td>{6}</td><td>{7}</td><td> <a href=""query.aspx?qId={8}""></a> </td>
                </tr>
                   ", i, value.natureOfQuery, value.issuedBy, value.dateIssued.ToShortDateString(), value.reply, value.dateReplied, value.actionTaken, value.disciplinaryEffectDate, value.Id));
                }
                i++;

            }
            queryString.Text = sb.ToString();

        }
    }
}