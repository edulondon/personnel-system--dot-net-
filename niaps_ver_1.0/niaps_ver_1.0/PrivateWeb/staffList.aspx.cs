using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class staffList : System.Web.UI.Page
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
                 getAllStaff();
             }
        }
        public void getActiveStaff()
        {
            niapsEntities1 db = new niapsEntities1();
            StringBuilder sb = new StringBuilder();
            var result = db.staffRecords.Where(st => st.status == "active");
            sb.Append(string.Format(@"<table class=""table table-striped table-hover""><thead>
         
         <tr><td>Staff Id</td><td>Last Name</td><td >First Name</td><td>Middle Name</td><td>Gender</td><td>Status</td><td colspan=""2""></td></tr></thead><tbody>"));

            foreach (var value2 in result)
            {
                sb.Append(string.Format(@"<tr>
                     <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td><td>{5} </td><td><a href=""staffDetails.aspx?staffId={6}"">detail</a></td><td><a href=""updateStaff.aspx?staffId={7}"">update</a></td><td><a href=""deactivateStaff.aspx?staffId={8}"">de/activate</a></td>
                </tr>
                   ", value2.staffId, value2.lName, value2.fName, value2.middleName, value2.gender, value2.status, value2.staffId, value2.staffId, value2.staffId));
                
            }
            sb.Append(string.Format(@"</tbody></table>"));
            staffDetail.Text = sb.ToString();
            
        }

        public void getInactiveStaff()
        {
            niapsEntities1 db = new niapsEntities1();
            StringBuilder sb = new StringBuilder();
            var result = db.staffRecords.Where(st => st.status == "inactive");
            sb.Append(string.Format(@"<table class=""table""><thead>
         
<tr><td>Staff Id</td><td>Last Name</td><td >First Name</td><td>Middle Name</td><td>Gender</td><td>Status</td><td colspan=""2""></td></tr></thead><tbody>"));
            foreach (var value2 in result)
            {
                sb.Append(string.Format(@"<tr>
                     <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td><td style=""color:red"">{5} </td><td><a href=""staffDetails.aspx?staffId={6}"">detail</a></td><td><a href=""updateStaff.aspx?staffId={7}"">update</a></td><td><a href=""deactivateStaff.aspx?staffId={8}"">de/activate</a></td>
                </tr>
                   ", value2.staffId, value2.lName, value2.fName, value2.middleName, value2.gender, value2.status, value2.staffId, value2.staffId, value2.staffId));

            }
            sb.Append(string.Format(@"</tbody></table>"));
            staffDetail.Text = sb.ToString();
        }

        public void getAllStaff()
        {
            niapsEntities1 db = new niapsEntities1();
            StringBuilder sb = new StringBuilder();
           var result = db.staffRecords;
           sb.Append(string.Format(@"<table class=""table""><thead>
         
         <tr><td>Staff Id</td><td>Last Name</td><td >First Name</td><td>Middle Name</td><td>Gender</td><td>Status</td><td colspan=""2""></td></tr></thead><tbody>"));
            foreach (var value2 in result)
            {
                if (value2.status.Equals("active"))
                {
                    sb.Append(string.Format(@"<tr>
                     <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td><td>{5} </td><td><a href=""staffDetails.aspx?staffId={6}"">detail</a></td><td><a href=""updateStaff.aspx?staffId={7}"">update</a></td><td><a href=""deactivateStaff.aspx?staffId={8}"">de/activate</a></td>
                </tr>
                   ", value2.staffId, value2.lName, value2.fName, value2.middleName, value2.gender, value2.status, value2.staffId, value2.staffId, value2.staffId));
                }
                else
                {
                    sb.Append(string.Format(@"<tr>
                     <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td><td style=""color:red"">{5} </td><td><a href=""staffDetails.aspx?staffId={6}"">detail</a></td><td><a href=""updateStaff.aspx?staffId={7}"">update</a></td><td><a href=""deactivateStaff.aspx?staffId={8}"">de/activate</a></td>
                </tr>
                   ", value2.staffId, value2.lName, value2.fName, value2.middleName, value2.gender, value2.status, value2.staffId, value2.staffId, value2.staffId));
                }
            }
            sb.Append(string.Format(@"</tbody></table>"));
            staffDetail.Text = sb.ToString();

            }

        protected void view_Click(object sender, EventArgs e)
        {
            if (filter.Text.Equals("All")) {
                getAllStaff();
            }
            else if (filter.Text.Equals("Active")) {
                getActiveStaff();
            }
            else {
                getInactiveStaff();
            }
        }

        protected void search_Click(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
            StringBuilder sb = new StringBuilder();
            string par = param.Text;
            var result = db.staffRecords.Where(st => st.lName.StartsWith(par) || st.fName.StartsWith(par) || st.middleName.StartsWith(par));
            if (result.Any())
            {
                sb.Append(string.Format(@"<table class=""table""><thead>
         
         <tr><th>Staff Id</th><th>Last Name</th><th>First Name</th><th>Middle Name</th><th>Gender</th><th>Status</th><th></th></tr></thead><tbody>"));
                foreach (var value2 in result)
                {
                    sb.Append(string.Format(@"<tr>
                        <td> {0}</td><td>{1} </td><td> {2}</td><td>{3} </td><td>{4} </td><td>{5} </td><td><a href=""staffDetails.aspx?staffId={6}"">detail</a></td><td><a href=""updateStaff.aspx?staffId={7}"">update</a></td><td><a href=""deactivateStaff.aspx?staffId={8}"">de/activate</a></td>
                </tr>
                   ", value2.staffId, value2.lName, value2.fName, value2.middleName, value2.gender, value2.status, value2.staffId, value2.staffId, value2.staffId));

                }
                sb.Append(string.Format(@"</tbody></table>"));
                staffDetail.Text = sb.ToString();
            }
            else
            {
                sb.Append(string.Format(@"<table class=""table""> <tr><td Style=""Text-color:Red; Text-align:Center"">No record found</td></tr>"));
                staffDetail.Text = sb.ToString();
            }
        }
    }
}