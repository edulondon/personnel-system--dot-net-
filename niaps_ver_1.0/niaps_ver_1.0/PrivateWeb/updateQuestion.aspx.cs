using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateQuestion : System.Web.UI.Page
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
                try{
                int sId = Int32.Parse(Request.QueryString["qid"]);
                var result = db.questions.Where(at => at.id == sId).First();
                no.Text = (result.qstId).ToString();
                qst.Text = result.question1;
                
                }
                catch (Exception ex)
                {
                    msg.Text = ex.Message;
                }
                }



        }

        protected void done_Click(object sender, EventArgs e)
        {
            try
            {
                int sId = Int32.Parse(Request.QueryString["qid"]);
                var ar = db.questions.FirstOrDefault(ai => ai.id == sId);
                ar.qstId = Int32.Parse(no.Text);
                ar.question1 = qst.Text;
                db.SaveChanges();
               
                msg.Text = "Question Updated Successfully";
            }
            catch (Exception ex)
            {
                msg.Text = ex.Message;
            }
        }
    }
}