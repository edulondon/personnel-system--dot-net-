using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class niaAssetDetails : System.Web.UI.Page
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
            string sId = Request.QueryString["assetId"].ToString();
            var query = db.assetRecords.Where(code => code.assetId == sId).First();
            string insuranceCode = query.insurance;
            // insuranceCompany ic = new insuranceCompany();
            var result2 = db.insuranceCompanies.Where(ic => ic.insuranceCode == insuranceCode).First();
            coy.Text = result2.nameOfCompany;
        }
        public List<assetRecord> GetAssetDetail()
        {

            string sId = Request.QueryString["assetId"].ToString();
            var result = db.assetRecords.Where(at => at.assetId == sId).ToList();

            return result.ToList();

        }
    }
}