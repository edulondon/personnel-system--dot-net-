using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0
{
    public partial class dataSheetUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string path = string.Concat((Server.MapPath("~/temp/" + FileUpload1.FileName)));
                FileUpload1.PostedFile.SaveAs(path);
                OleDbConnection OleDbcon = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;");
                OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$]", OleDbcon);
                OleDbDataAdapter odr = new OleDbDataAdapter(cmd);

                OleDbcon.Open();
                DataSet ds = new DataSet();
                odr.Fill(ds);
                odr.Dispose();
                OleDbcon.Close();
                OleDbcon.Dispose();

                using (niapsEntities1 db = new niapsEntities1())
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        try
                        {
                            assetRecord ct = new assetRecord();
                            ct.assetId = dr["ASSET_ID"].ToString();
                            ct.name = dr["ASSET_NAME"].ToString();
                            CultureInfo provider = new CultureInfo("en-US");
                            Thread.CurrentThread.CurrentCulture = provider;
                            ct.datePurchased = DateTime.Parse(dr["DATE_PURCHASED"].ToString());
                            ct.receivingDept = dr["RECEIVING_DEPT"].ToString();
                            ct.cost = decimal.Parse(dr["COST"].ToString());
                            ct.remark = dr["REMARK"].ToString();
                            ct.insurance = dr["INSURER"].ToString();
                            ct.policyNumber = dr["INSURANCE_POLICY_No"].ToString();
                            ct.sumInsured = decimal.Parse(dr["SUM_INSURED"].ToString());
                            CultureInfo provider1 = new CultureInfo("en-US");
                            Thread.CurrentThread.CurrentCulture = provider1;
                            ct.coverDate = DateTime.Parse(dr["COVER_DATE"].ToString());
                            CultureInfo provider2 = new CultureInfo("en-US");
                            Thread.CurrentThread.CurrentCulture = provider2;
                            ct.expirydate = DateTime.Parse(dr["EXPIRY_DATE"].ToString());
                            ct.status = dr["STATUS"].ToString();
                            ct.vendor = dr["VENDOR"].ToString();
                            ct.premium = dr["PREMIUM"].ToString();
                            db.assetRecords.Add(ct);
                            db.SaveChanges();
                            Label1.ForeColor = Color.Green;
                            Label1.Text = "Successfully inserted";

                        }
                        catch (Exception ex)
                        {
                            Label1.ForeColor = Color.Red;
                            Label1.Text = ex.Message;
                        }
                    }
                }
            }
            else
            {
                Label1.ForeColor = Color.Red;
                Label1.Text = "Please select the file";



            }
        }
    }
}