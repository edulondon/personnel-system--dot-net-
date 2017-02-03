using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class sviewUsers : System.Web.UI.Page
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

            if (Request.QueryString["msg"] != string.Empty)
            {
                string mg = Request.QueryString["msg"];
                msg.Text = mg;
            }
            getUsers();
        }

        public void getUsers()
        {
            niapsEntities1 db = new niapsEntities1();
            // news ne = new news();
            var msg = db.adminUsers.OrderByDescending(n => n.status == "active");
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(@"<tbody>"));
            foreach (var value in msg)
            {
                if (value.status.Equals("active"))
                {
                    sb.Append(string.Format(@"
                    <tr>
                       <td>{15}</td> <td>{0}</td><td>{1} </td> <td>{2}</td><td><a href= ""supdateUser.aspx?uid= {3}&uname={4}&role={5}&status={6}"">de/activate</a></td>
               <td><a href= ""sdeleteUser.aspx?uid= {7}&uname={8}&role={9}&status={10}"">delete</a></td><td><a href= ""smodifyUserPassword.aspx?uid= {11}&uname={12}&role={13}&status={14}"">modify password</a></td> </tr>
	                ", value.userName, verifyRole(value.role), value.status, value.userId, value.userName, value.role, value.status, value.userId, value.userName, value.role, value.status, value.userId, value.userName, value.role, value.status, value.full_name));
                }
                else
                {
                    sb.Append(string.Format(@"
                    <tr>
                       <td>{15}</td>  <td>{0}</td><td>{1} </td> <td style=""color:red"">{2}</td><td><a href= ""supdateUser.aspx?uid= {3}&uname={4}&role={5}&status={6}"">de/activate</a></td>
               <td><a href= ""sdeleteUser.aspx?uid= {7}&uname={8}&role={9}&status={10}"">delete</a></td><td><a href= ""smodifyUserPassword.aspx?uid= {11}&uname={12}&role={13}&status={14}"">modify password</a></td> </tr>
	                ", value.userName, verifyRole(value.role), value.status, value.userId, value.userName, value.role, value.status, value.userId, value.userName, value.role, value.status, value.userId, value.userName, value.role, value.status, value.full_name));
                }
            }
            sb.Append(string.Format(@"</tbody>"));
            newsLabel.Text = sb.ToString();
            db.Dispose();

        }
        public string verifyRole(string st)
        {
            if (st.Equals("admin"))
            {
                st = "Super Admin";
            }
            else if (st.Equals("hr"))
            {
                st = "Human Resource";
            }
            else if (st.Equals("secret'l"))
            {
                st = "secretarial";
            }
            else
            {
                st = "inventory";
            }
            return st;
        }
    }
}