using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PublicWeb
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Contents.Remove("username");
            Session.Contents.Remove("staffid");
            Session.Contents.Remove("role");
            Response.Redirect("../Default.aspx?msg=Logout successful!!!");
        }
    }
}