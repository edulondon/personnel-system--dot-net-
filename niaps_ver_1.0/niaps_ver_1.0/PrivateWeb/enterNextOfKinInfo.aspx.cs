using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class enterNextOfKinInfo : System.Web.UI.Page
    {
        private niapsEntities1 db = new niapsEntities1();
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
            //if (Request.QueryString["staffId"].ToString() == "" && Request.QueryString["staffId"].ToString() == null)
            //{
            //    string sId = Request.QueryString["staffId"].ToString();
            //    string name = Request.QueryString["name"].ToString();
            //    Response.Redirect("createStaff.aspx?msg=" + msg.Text + "= register a staff first");
            //}
        }

        protected void create_Click(object sender, EventArgs e)
        {
            try
            {
                staffNextOfKin st = new staffNextOfKin();
                string sId = Request.QueryString["staffId"].ToString();
                string name = Request.QueryString["name"].ToString();

                st.staffId = sId;
                st.fName = fname.Text;
                st.lname = ln.Text;
                st.gender = sex.Text;
                st.address = addr.Text;
                st.contactMobile = phone.Text;
                st.relationship = rel.Text;
                db.staffNextOfKins.Add(st);
                db.SaveChanges();
               // msg.Text = "Registration Completed Successfully";

               // Response.Redirect("enterQualification.aspx?staffId=" + sId);
                
                //Response.Redirect("../PrivateWeb/message.aspx?msg=" + msg);
            }
            
            catch (Exception exc) {
                msg.Text += exc.Message;
            }
        }
    }
}