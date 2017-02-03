using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class niaGoals : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string name = Request.Cookies["fullName"].Value;
                string role = Request.Cookies["role"].Value;
            }
            catch (Exception)
            {
                Response.Redirect("../Default.aspx");
            }
        }
    }
}