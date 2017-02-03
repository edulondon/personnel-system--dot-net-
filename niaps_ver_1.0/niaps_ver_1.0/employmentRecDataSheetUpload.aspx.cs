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
    public partial class employmentRecDataSheetUpload : System.Web.UI.Page
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
                    employmentRecord er = new employmentRecord();
                    currentStaffRecord cst = new currentStaffRecord();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        try
                        {
                            er.staffId = dr["Staff_id_No"].ToString();
                            er.company = dr["Company"].ToString();

                            string dateString = dr["DateJoined"].ToString();
                            CultureInfo provider = new CultureInfo("en-US");
                            Thread.CurrentThread.CurrentCulture = provider;
                            DateTime sd = DateTime.Parse(dateString);
                            er.startDate = sd;

                            string dateString1 = dr["Date_Left"].ToString();
                            DateTime ed = DateTime.Parse(dateString1);
                            er.endDate = ed;
                            er.postHeld = dr["Post_held"].ToString();
                            er.duties = dr["Duties"].ToString();
                            db.employmentRecords.Add(er);
                            db.SaveChanges();

                            cst.staffId = dr["Staff_id_No"].ToString();
                            cst.designation = dr["Designation"].ToString();
                            cst.department = dr["Department"].ToString();
                            cst.qualification = Request.QueryString["bq"].ToString();
                            CultureInfo provider2 = new CultureInfo("en-US");
                            Thread.CurrentThread.CurrentCulture = provider2;
                            cst.date_Joined = DateTime.Parse(dr["Dete_of_employment"].ToString());
                            cst.degree = Request.QueryString["degree"].ToString();
                            cst.probationPeriod = Int32.Parse(dr["Probation_Period"].ToString());
                            string conDate = dr["ConfirmationDate"].ToString();
                            cst.dateOfConfirmation = DateTime.Parse(conDate);
                            db.currentStaffRecords.Add(cst);
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

    
       