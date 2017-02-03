using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class staffArchive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
            // news ne = new news();
            var msg = db.staffUpdateHistories.OrderByDescending(n => n.updatDate);
            StringBuilder sb = new StringBuilder();

            foreach (var value in msg)
            {
                sb.Append(string.Format(@"<table  class=""table"">
                    <tr>
                        <td>Staff ID:</td><td>{0} </td>
                </tr>
                <tr>
                        <td>Staff Name:</td><td>{1}</td>
                </tr>
                    <tr>
                        <td>Description:</td><td>{2}&nbsp;&nbsp;&nbsp;Date Mordified:&nbsp; {3}</td>
                </tr>
	                </table>", value.staffId, value.updatedBy, value.description, value.updatDate.ToShortDateString()));

            }
            sArchive.Text = sb.ToString();
            db.Dispose();
        
        
        }
    }
}