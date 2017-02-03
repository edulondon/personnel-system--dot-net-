using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0
{
    public partial class newsRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             niapsEntities1 db = new niapsEntities1();
           // news ne = new news();
            var msg = db.news.OrderByDescending(n=>n.date);
            StringBuilder sb = new StringBuilder();
           
                foreach(var value in msg)
                {
                    sb.Append(string.Format(@"<table  id=""box-table-a"">
                    <tr>
                        <td>Title:</td><td>{0} </td>
                </tr>
                <tr>
                        <td></td><td>{1}</td>
                </tr>
                    <tr>
                        <td>Author:</td><td>{2}&nbsp;&nbsp;&nbsp;Date:&nbsp; {3}</td>
                </tr>
	                </table>",value.postebBy, value.message, value.newsBy, value.date.ToShortDateString()));
                   
            }
                newsLabel.Text = sb.ToString();
                db.Dispose();
        
        
        
        }
    }
}