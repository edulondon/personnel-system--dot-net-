using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class postNews : System.Web.UI.Page
    {
        niapsEntities1 db = new niapsEntities1();
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
            if (!IsPostBack)
            {
                getNews();
            }
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            if (author.Text == string.Empty)
            {
                aError.Text = "*";
            }
            else if (postBy.Text == string.Empty)
            {
                tError.Text = "*";
            }
            else if (news.Text == string.Empty)
            {
                nError.Text = "*";
            }
            else
            {
                try
                {
                    news ne = new news();
                    ne.newsBy = author.Text;
                    ne.postebBy = postBy.Text;
                    ne.message = news.Text;
                    DateTime dt = DateTime.Now;
                    ne.date = dt;
                    db.news.Add(ne);
                    db.SaveChanges();
                    db.Dispose();
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""News Posted Successfully... click OK to continue!"")</SCRIPT>"));
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""postNews.aspx"") </SCRIPT>"));
                   // msg.Text = "News posted successfully";
                    author.Text = "";
                    postBy.Text = "";
                    news.Text = "";
                }
                catch (Exception)
                {
                    msg.Text = "News failed";
                }
            }
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
                sb.Append(string.Format(@"<table width='400px'>
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
            newsLabel.Text = sb.ToString();
            db.Dispose();

        }

    }
}