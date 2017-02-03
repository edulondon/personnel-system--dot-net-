using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb.uploadedfiles
{
    public partial class viewUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static List<adminUser> GetUser()
        {

            niapsEntities1 db = new niapsEntities1();
            var result = db.adminUsers;
            return result.ToList();


        }
    }
}