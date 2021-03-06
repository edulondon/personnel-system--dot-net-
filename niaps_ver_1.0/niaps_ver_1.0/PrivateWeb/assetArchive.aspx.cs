﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class assetArchive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            niapsEntities1 db = new niapsEntities1();
            // news ne = new news();
            var msg = db.assetUpdateHistories.OrderByDescending(n => n.updateDate);
            StringBuilder sb = new StringBuilder();

            foreach (var value in msg)
            {
                sb.Append(string.Format(@"<table  class=""table"">
                    <tr>
                        <td>Asset ID:</td><td>{0} </td>
                </tr>
                <tr>
                        <td>Description:</td><td>{1}</td>
                </tr>
                    <tr>
                        <td>Date:</td><td>{2}</td>
                </tr>
	                </table>", value.assetId, value.message, value.updateDate.ToShortDateString()));

            }
            aArchive.Text = sb.ToString();
            db.Dispose();
        
        
        }
    }
}