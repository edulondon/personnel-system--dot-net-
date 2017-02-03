using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class index : System.Web.UI.Page
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
            getNews();
        }
        public void getNews()
        {
            niapsEntities1 db = new niapsEntities1();
            // news ne = new news();
            var msg = db.news.OrderByDescending(n => n.date);
            StringBuilder sb = new StringBuilder();
            int i = 1;
            foreach (var value in msg)
            {
                sb.Append(string.Format(@"<table class=""table"">
                    <tr>
                        <td>Title:</td><td>{0} </td>
                </tr>
                <tr>
                        <td></td><td>{1}<a href=""newsRoom.aspx"">read more...</a></td>
                </tr>
                    <tr>
                        <td>Author:</td><td>{2}&nbsp;&nbsp;&nbsp;Date:&nbsp; {3}</td>
                </tr>
                    <tr>
                        <td></td><td></td>
                </tr>
	                </table>", value.postebBy, niaps_ver_1._0.truncString.TruncateAtWord(value.message, 70), value.newsBy, value.date.ToShortDateString()));
                if (i.Equals(5)) { break; }
                i++;
            }
            news.Text = sb.ToString();
            db.Dispose();

        }
        protected void btnUser_Click1(object sender, EventArgs e)
        {


        }
    }
}