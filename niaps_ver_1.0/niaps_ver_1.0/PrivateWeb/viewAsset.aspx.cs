using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class viewAsset : System.Web.UI.Page
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

            if (!IsPostBack) {
                getAsset();
            }
        }
        //public static List<assetRecord> GetAsset()
        //{
        //    niapsEntities1 db = new niapsEntities1();
        //    var result = db.assetRecords.OrderBy(re => re.datePurchased);
        //    return result.ToList();
           
        //}
        public void getAsset() { 
            niapsEntities1 db = new niapsEntities1();
            var result = db.assetRecords.OrderBy(re => re.datePurchased);
            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach (var value in result)
            {
                if (value.status.Equals("active"))
                {
                    sb.Append(string.Format(@"
                <tr>
                        <td> {0}</td><td> {1}</td><td>{2} </td><td> {3}</td><td>{4} </td><td style=""color:red"">{5} </td><td> <a href=""assetDetail.aspx?assetId={6}"">detail</a></td>
                </tr>
                   ", count, value.assetId, value.name, value.datePurchased.ToShortDateString(), value.receivingDept, value.status, value.assetId));
                    count++;
                }
                else {
                    sb.Append(string.Format(@"
                 <tr>
                        <td> {0}</td><td> {1}</td><td>{2} </td><td> {3}</td><td>{4} </td><td style=""color:red"">{5} </td><td> <a href=""assetDetail.aspx?assetId={6}"">detail</a></td>
                </tr>
                   ", count, value.assetId, value.name, value.datePurchased.ToShortDateString(), value.receivingDept, value.status, value.assetId));
                    count++;
                }
            }
            assetLabel.Text = sb.ToString();
            
       
        }
    }
}