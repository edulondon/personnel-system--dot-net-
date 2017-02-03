using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class query : System.Web.UI.Page
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
            try
            {

                string sId = Session["staffId"].ToString();
                string qd = Request.QueryString["qId"].ToString();
                int qId = Int32.Parse(qd);
                var query = db.queries.Where(q => q.staffId == sId && q.Id==qId).First();
                staffid.Text = query.staffId;
                    nq.Text = query.natureOfQuery;
                    di.Text = query.dateIssued.ToShortDateString();
                    act.Text = query.actionTaken;
            }
            catch (Exception)
            {
                msg.Text = "error retrieving query, pls, contact HR!";
            }
        }

        protected void answer_Click(object sender, EventArgs e)
        {
            try
            {
                string qid = Request.QueryString["qId"].ToString();
                int qd = Int32.Parse(qid);
                var iq = db.queries.FirstOrDefault(i => i.staffId == staffid.Text && i.Id == qd);
                iq.status = "replied";
                iq.reply = ans.Text;
                iq.index = 1;
                iq.dateReplied = DateTime.Now;
                
                db.SaveChanges();
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Reply posted successfully... click OK to continue!"")</SCRIPT>"));
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""index.aspx"") </SCRIPT>"));
               // msg.Text = "Query updated successfully";
            }
            catch (Exception)
            {
                msg.Text = "Error, update failed";
            }
        }
       
    }
}