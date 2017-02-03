using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class deleteUser : System.Web.UI.Page
    {
        niapsEntities1 db = new niapsEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int uId = Int32.Parse(Request.QueryString["uid"].ToString());
           // var d = db.adminUsers.FirstOrDefault(cs => cs.userId == uId);
           //db.d
            //var stud = (from s1 in db.adminUsers where s1.userId == uId select s1).FirstOrDefault();
            //db.rem
            var stud = new adminUser { userId = uId };
            db.adminUsers.Attach(stud);
            db.adminUsers.Remove(stud);
            db.SaveChanges();
            msg.Text = "user deleted successfully";
        }
    }
}