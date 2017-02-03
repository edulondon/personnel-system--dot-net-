using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class updateAppraisal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                niapsEntities1 db = new niapsEntities1();
                var upck = db.activateReviews.Where(up => up.Id == 1).First();
                if (upck.status == "inactive") {

                    Response.Redirect("reviewMessage.aspx");
                }
            
            }
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
                    string sId = Session["staffId"].ToString();//Request.QueryString["staffId"].ToString();
                    niapsEntities1 db = new niapsEntities1();
                    var review = db.staffRecords.Where(rev => rev.staffId == sId).First();
                    var review2 = db.currentStaffRecords.Where(rev2 => rev2.staffId == sId).First();

                    // StringBuilder sb = new StringBuilder();
                    string surName = review.lName;
                    string lastName = review.fName;
                    string fullName = surName + ", " + lastName;

                    sname.Text = fullName;
                    stId.Text = sId;
                    des.Text = review2.designation;
                    jdate.Text = DateTime.Parse(review2.date_Joined.ToString()).ToShortDateString();
                    qoe.Text = review2.qualification;

                    var update = db.answerToQuestions.Where(up => up.staffId == sId & up.indicator == 0).First();
                    TextBox1.Text = update.answer1;
                    TextBox2.Text = update.answer2;
                    TextBox3.Text = update.answer3;
                    TextBox4.Text = update.answer4;
                    TextBox5.Text = update.answer5;
                    TextBox6.Text = update.answer6;
                    TextBox7.Text = update.answer7;
                    TextBox8.Text = update.answer8;
                    TextBox9.Text = update.answer9;
                    TextBox10.Text = update.answer10;
                    TextBox11.Text = update.answer11;
                    TextBox12.Text = update.answer12;
                    TextBox13.Text = update.answer13;
                    TextBox14.Text = update.answer14;
                    TextBox15.Text = update.answer15;
                    TextBox16.Text = update.answer16;
                }
                catch (Exception)
                {
                    msg.Text = "Could not find questions";
                    //  msg.Text += qx.Message;
                }
            }
        }

        protected void btnReview_Click(object sender, EventArgs e)
        {

            niapsEntities1 db = new niapsEntities1();
           // string sId = Session["staffId"].ToString();
            try
            {
                string sId = stId.Text;
                var update = db.answerToQuestions.FirstOrDefault(up => up.staffId == sId);
                update.answer1 = TextBox1.Text;
                update.answer2 = TextBox2.Text;
                update.answer3 = TextBox3.Text;
                update.answer4 = TextBox4.Text;
                update.answer5 = TextBox5.Text;
                update.answer6 = TextBox6.Text;
                update.answer7 = TextBox7.Text;
                update.answer8 = TextBox8.Text;
                update.answer9 = TextBox9.Text;
                update.answer10 = TextBox10.Text;
                update.answer11 = TextBox11.Text;
                update.answer12 = TextBox12.Text;
                update.answer13 = TextBox13.Text;
                update.answer14 = TextBox14.Text;
                update.answer15 = TextBox15.Text;
                update.answer16 = TextBox16.Text;
                db.SaveChanges();
                msg.Text = "Update Successful";
            }
            catch (Exception)
            {
                msg.Text = "Update failed";
            }
        }
    }
}