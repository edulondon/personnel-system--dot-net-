using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateQuery : System.Web.UI.Page
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
                 try
                 {

                     string sId = Request.QueryString["staffId"].ToString();
                     int qId = Int32.Parse(Request.QueryString["queryId"]);
                     var query = db.queries.Where(q => q.staffId == sId && q.Id == qId).First();
                     otherNames.Text = query.staffId;
                     natuerOfQuery.Text = query.natureOfQuery;
                     issuedBy.Text = query.issuedBy;
                     dati.Text = query.dateIssued.ToShortDateString();
                     reply.Text = query.reply;
                     actionT.Text = query.actionTaken;
                     discDate.Text = DateTime.Parse(query.disciplinaryEffectDate.ToString()).ToShortDateString();
                     //status.Text = query.status;
                 }
                 catch (Exception)
                 {
                     msg.Text = "error retrieving query!";
                 }
             }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (actionT.Text == string.Empty)
            {
                aError.Text = "*";
            }
             try
            {
                 string sId = Request.QueryString["staffId"].ToString();
                 int qId = Int32.Parse(Request.QueryString["queryId"]);
                 var iq = db.queries.FirstOrDefault(i => i.staffId == sId && i.Id == qId);
                iq.actionTaken = actionT.Text;
                iq.disciplinaryEffectDate = DateTime.Parse(discDate.Text);
                db.SaveChanges();
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""query updated successfully... click OK to continue!"")</SCRIPT>"));
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""viewQuery.aspx"") </SCRIPT>"));
               // msg.Text = "Query updated successfully";
            }
            catch (Exception)
            {
                msg.Text = "Error, update failed";
            }
        
        }

        protected void discDate_TextChanged(object sender, EventArgs e)
        {
            if (discDate.Text == string.Empty)
            {
                daError.Text = "*";
            }
            try
            {
                DateTime dd = DateTime.Parse(discDate.Text);
                DateTime cd = DateTime.Now;
                if ((dd.Year < cd.Year) && (dd.Year > cd.Year))
                {
                    daError.Text = "*";
                    discDate.Text = "";
                }
                else if (dd.Month < cd.Month)
                {
                    daError.Text = "*";
                    discDate.Text = "";
                }else if((dd.Month) - (cd.Month)>2){
                    daError.Text = "*";
                    discDate.Text = "";
                }
            }
            catch (Exception)
            {
                daError.Text = "*";
                discDate.Text = "";
            }
        }
    }
}