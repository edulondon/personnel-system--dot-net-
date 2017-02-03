using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class staffReview : System.Web.UI.Page
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
            try
            {
                niapsEntities1 dbase = new niapsEntities1();
                var available = dbase.activateReviews.Where(av => av.Id == 1 && av.reviewId == 2).First();
                if (available.status == "inactive")
                {
                    Response.Redirect("reviewMessage.aspx");
                }
            }
            catch (Exception)
            {
                Response.Redirect("reviewMessage.aspx");
            }
            niapsEntities1 db = new niapsEntities1();
            string sId = Session["staffId"].ToString();
            var review = db.staffRecords.Where(rev => rev.staffId == sId).First();
            var review2 = db.currentStaffRecords.Where(rev2 => rev2.staffId == sId).First();
            string surName = review.lName;
            string lastName = review.fName;
            string fullName = surName + ", " + lastName;
            sname.Text = fullName;
            stId.Text = sId;
            des.Text = review2.designation;
            jdate.Text = review2.date_Joined.ToString();
            dept.Text = review2.department;
            qoe.Text = review2.qualification;

        }
        protected void btnReview_Click(object sender, EventArgs e)
        {
            
            try
            {
                string stfId = stId.Text;
                niapsEntities1 db = new niapsEntities1();
                var ck = db.activateReviews.Where(ch => ch.Id == 1).First();
                var chk = db.answerToQuestions.Where(c => c.staffId == stfId).First();
                msg.Text = "Sorry, you can only take the appraisal once. to make modifications, click on update appraisal on the menu bar";
                //string ansid = chk.qstId.ToString();
                //string rid = ck.reviewId.ToString();
                

            }
            catch (Exception)
            {
                niapsEntities1 db = new niapsEntities1();
                var ind = db.indicators.First();
                string qrt = ind.quarter;
                string yr = ind.year;
                string stfId = stId.Text;
                answerToQuestion ans = new answerToQuestion();
                var rid = db.activateReviews.Where(r => r.Id == 1).First();
               // ans.qstId = rid.reviewId;
                ans.staffId = stfId;
                ans.date = DateTime.Now;
                ans.answer1 = TextBox1.Text;
                ans.answer2 = TextBox2.Text;
                ans.answer3 = TextBox3.Text;
                ans.answer4 = TextBox4.Text;
                ans.answer5 = TextBox5.Text;
                ans.answer6 = TextBox6.Text;
                ans.answer7 = TextBox7.Text;
                ans.answer8 = TextBox8.Text;
                ans.answer9 = TextBox9.Text;
                ans.answer10 = TextBox10.Text;
                ans.answer11 = TextBox11.Text;
                ans.answer12 = TextBox12.Text;
                ans.answer13 = TextBox13.Text;
                ans.answer14 = TextBox14.Text;
                ans.answer15 = TextBox15.Text;
                ans.answer16 = TextBox16.Text;
                ans.quarter = qrt;
                ans.year = yr;
                ans.indicator = 0;
                db.answerToQuestions.Add(ans);
                db.SaveChanges();
               // msg.Text = "Congratulations!!!Review submitted successfully";
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Congratulations!!!Review submitted successfully... click OK to continue!"")</SCRIPT>"));
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""index.aspx"") </SCRIPT>"));
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                TextBox11.Text = "";
                TextBox12.Text = "";
                TextBox13.Text = "";
                TextBox14.Text = "";
                TextBox15.Text = "";
                TextBox16.Text = "";
                

            }
        }
    }
}