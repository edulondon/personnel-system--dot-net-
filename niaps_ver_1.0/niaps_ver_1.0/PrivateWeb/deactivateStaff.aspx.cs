using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class deactivateStaff : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                try
                {
                    string stid = Request.QueryString["staffId"];
                    sid.Text = stid;
                    niapsEntities1 db = new niapsEntities1();
                    var result = db.staffRecords.Where(st => st.staffId == stid).First();
                    string lname = result.lName;
                    string fname = result.fName;
                    string mname = result.middleName;
                    name.Text = lname + ", " + fname + " " + mname;
                    img.Text = "<asp:Image ID='Image1' runat='server' ImageUrl=" + result.passport + " Width='150px' Height='150px'/>";
                    string stat = result.status;
                    if (stat.Equals("active")) { dt.Checked = false; } else { dt.Checked = true; }
                }
                catch (Exception) { msg.Text = "No record found!"; }
            }

        }

        protected void deactivate_Click(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
            string stid = Request.QueryString["staffId"];
            var update = db.staffRecords.FirstOrDefault(cs => cs.staffId == stid);
            if (dt.Checked)
            {
                update.status = "inactive";
                db.SaveChanges();
                msg.Text = "staff deactivated";

            }
            else
            {
                update.status = "active";
                db.SaveChanges();
                msg.Text = "staff activated";
            }
        }
    }
}