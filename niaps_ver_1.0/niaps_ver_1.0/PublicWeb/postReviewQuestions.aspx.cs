using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class postReviewQuestions : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
            question qstn = new question();
            qstn.question1 = qst.Text;
            qstn.qstId = Int32.Parse(qstno.Text);
            db.questions.Add(qstn);
            db.SaveChanges();
            
        }
    }
}