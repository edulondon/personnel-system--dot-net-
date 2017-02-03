using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class update : System.Web.UI.Page
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
                int nId = Int32.Parse(Request.QueryString["newsId"].ToString());
                var rnews = db.news.Where(rn => rn.newsId == nId).First();
                author.Text = rnews.newsBy;
                postBy.Text = rnews.postebBy;
                news.Text = rnews.message;
                db.Dispose();
                // if (stat.Equals("active")) { dt.Checked = false; } else { dt.Checked = true; }
            }
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                int nId = Int32.Parse(Request.QueryString["newsId"].ToString());
                var update = db.news.FirstOrDefault(cs => cs.newsId == nId);
                update.newsBy = author.Text;
                update.postebBy = postBy.Text;
                update.message = news.Text;
                db.SaveChanges();
                msg.Text = "news updated successfully";
            }
            catch (Exception)
            {
                msg.Text = "news update failed";
            }

        }
    }
}