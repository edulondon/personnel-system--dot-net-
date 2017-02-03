using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateEmploymentRec : System.Web.UI.Page
    {
             private niapsEntities1 db = new niapsEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string sId = Request.QueryString["staffId"].ToString();

            }
            catch(Exception) {
                Response.Redirect("updateS.aspx");
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
                     string sId = Request.QueryString["staffId"].ToString();
                     int qid = Int32.Parse(Request.QueryString["Id"].ToString());
                     var emp = db.employmentRecords.Where(em => em.Id == qid).First();
                     coy.Text = emp.company;
                     sdate.Text = emp.startDate.ToShortDateString();
                     edate.Text = DateTime.Parse(emp.endDate.ToString()).ToShortDateString();
                     ph.Text = emp.postHeld;
                     duties.Text=emp.duties;

                     var staffRec = db.staffRecords.Where(st => st.staffId == sId).First();
                     string sid = staffRec.staffId;
                     string fname = staffRec.fName;
                     string mname = staffRec.middleName;
                     sname.Text = staffRec.lName + ", " + fname + "  " + mname + "      Id    " + sid;
                 }
                 catch (Exception)
                 {
                     msg.Text = "error reading data";
                 }
             }
        }

        protected void update_Click(object sender, EventArgs e)
        {
             try
            {
                int qid = Int32.Parse(Request.QueryString["Id"].ToString());
                var ufq = db.employmentRecords.FirstOrDefault(uf => uf.Id == qid);
                ufq.company = coy.Text;
                ufq.startDate = DateTime.Parse(sdate.Text);
                 ufq.endDate = DateTime.Parse(edate.Text);
                ufq.postHeld = ph.Text;
                ufq.duties = duties.Text;
                db.SaveChanges();

                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""updated Successfully... click OK to continue!"") </SCRIPT>"));
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""updateEmpRec.aspx"") </SCRIPT>"));

                sdate.Text = "";
                coy.Text = "";
                edate.Text = "";
                ph.Text = "";
                duties.Text = "";
            }
            catch (Exception)
            {
                msg.Text = "update failed";
            }
            //Response.Redirect("updateS.aspx");
        }
        }
    }