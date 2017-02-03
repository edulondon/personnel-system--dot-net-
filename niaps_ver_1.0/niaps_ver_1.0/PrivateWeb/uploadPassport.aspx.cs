using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class uploadPassport : System.Web.UI.Page
    {
        private niapsEntities1 db = new niapsEntities1(); 

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
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string theFile = txtFile.PostedFile.FileName;
            string filepath = MapPath("images/") + theFile;
            //Response.Write(filepath);
           try{
	                txtFile.PostedFile.SaveAs(filepath);
                 
            }catch(Exception){
                throw new Exception("File was not saved!");
                }
           staffRecord st = new staffRecord();
           string sId = Request.QueryString["staffId"].ToString();
           string name = Request.QueryString["name"].ToString();
           var result = db.staffRecords.Where(est => est.staffId == sId).First();
           result.passport = "~/PrivateWeb/images/" + theFile.ToString();
          // st.passport = filepath;
           //db.staffRecords.Add(result);
           db.SaveChanges();
           Response.Redirect("../PrivateWeb/enterEmploymentRecord.aspx?staffId=" + sId + "&name=" + name + "next");
        }
    }
}