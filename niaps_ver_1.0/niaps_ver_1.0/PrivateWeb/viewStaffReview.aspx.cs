using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class viewStaffReview : System.Web.UI.Page
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
        }

        protected void staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
            string sid = staff.SelectedValue;
            int ryear =Int32.Parse( yr.SelectedValue);
            string qtrs = qtr.SelectedValue;
            try
            {
                var detail = db.staffRecords.Where(de => de.staffId == sid).First();
                var det = db.currentStaffRecords.Where(dt => dt.staffId == sid).First();
                displayDetail.Text = "Name: " + detail.lName + ",&nbsp;&nbsp;" + detail.fName + " &nbsp;&nbsp;&nbsp;" + detail.middleName;
                displayDetails2.Text = "Id: " + detail.staffId + "   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Department: " + det.department + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Designation:  " + det.designation;
                var rev = db.activateReviews.Where(r => r.Id == 1).First();
                var query = db.answerToQuestions.Where(qu => qu.staffId == sid && qu.quarter == qtrs && qu.date.Year == ryear);
                if (query.Any())
                {
                    StringBuilder sb = new StringBuilder();
                    int i = 1;
                    foreach (var value in query)
                    {
                        sb.Append(string.Format(@"<table class=""table"">
                 <tr>
                    <td>1</td><td>Additional Qualification after Entry</td><td> {0}</td>
                </tr>
                <tr>
                    <td>2</td><td>Professional Qualification</td><td> {1}</td>
                </tr>
                <tr>
                    <td>3</td><td>Training course(s) attended since joining the Association</td><td> {2}</td>
                </tr>
                <tr>
                    <td>4</td><td>How long have you been involved in your current Directorate/Department?</td><td> {3}</td>
                </tr>
                <tr>
                    <td>5</td><td>Detail schedule of duties</td><td> {4}</td>
                </tr>
                <tr>
                    <td>6</td><td>Do you enjoy working in your current Directorate/Department? If No give reason(s)</td><td> {5}</td>
                </tr>
                <tr>
                    <td>7</td><td>What suggestion(s) would you give to help the Management improve your performance in your current Directorate/Department?</td><td> {6}</td>
                </tr>
                <tr>
                    <td>8</td><td>Refer to your objectives for this period. How well do you think you have performed against these objectives</td><td> {7}</td>
                </tr>
                   <tr>
                    <td>9</td><td> What problems have you encountered in achieving these objectives? Are there any actions the organization should take to minimize these problems in the future?</td><td> {8}</td>
                </tr>
                </tr>
                   <tr>
                    <td>10</td><td>What do you consider to be your main strengths?</td><td> {9}</td>
                </tr>
                </tr>
                   <tr>
                    <td>11</td><td>What do you consider to be your weakness?</td><td> {10}</td>
                </tr>
                </tr>
                   <tr>
                    <td>12</td><td>What training and/or development do you feel you need?</td><td> {11}</td>
                </tr>
                </tr>
                   <tr>
                    <td>13</td><td> State your major achievements within the period under review</td><td> {12}</td>
                </tr>
                </tr>
                   <tr>
                    <td>14</td><td>What overall performance rating best describes your performance over the period under review?</td><td> {13}</td>
                </tr>
                </tr>
                   <tr>
                    <td>15</td><td>What do you consider to be your most important tasks in the next year?</td><td> {14}</td>
                </tr>
                </tr>
                   <tr>
                    <td>16</td><td>Please insert any other comments below</td><td> {15}</td>
                </tr>
            </table>
                   ", value.answer1, value.answer2, value.answer3, value.answer4, value.answer5, value.answer6, value.answer7, value.answer8, value.answer9, value.answer10, value.answer11, value.answer12, value.answer13, value.answer14, value.answer15, value.answer16));
                        i++;
                    }
                    review.Text = sb.ToString();
                    sb.Clear();
                }
                else
                {
                    review.Text = string.Format(@" <span style=""text-align:center; color:red"">no data found for the selected staff</span>");
                }
               
            }catch (Exception){
                review.Text = string.Format(@" <span style=""text-align:center; color:red"">no data found for the selected staff</span>");
        } 

    }
    }
}