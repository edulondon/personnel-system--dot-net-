using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class updateNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
            // news ne = new news();
            var msg = db.news.OrderByDescending(n => n.date);
            int i = 1;
            StringBuilder sb = new StringBuilder();

            foreach (var value in msg)
            {
                sb.Append(string.Format(@"
                    <tr>
                        <td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td><a href=""update.aspx?newsId={4}"">update</a></td>
                </tr> ", i, value.postebBy, value.newsBy, value.date.ToShortDateString(), value.newsId));
                i++;
            }
            newsLabel.Text = sb.ToString();
            db.Dispose();


        }
    }
}