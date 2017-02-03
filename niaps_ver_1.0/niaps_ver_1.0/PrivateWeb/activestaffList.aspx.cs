using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class activestaffList : System.Web.UI.Page
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
        public static List<staffRecord> GetStaff()
        {

            niapsEntities1 db = new niapsEntities1();
            var result = db.staffRecords.Where(s => s.status == "active");
            return result.ToList();


        }
    }
}