using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class updateAsset : System.Web.UI.Page
    {
        niapsEntities1 db = new niapsEntities1();
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
                try
                {
                    string sId = Request.QueryString["assetId"].ToString();
                    var result = db.assetRecords.Where(at => at.assetId == sId).First();

                    aid.Text = result.assetId;
                    aname.Text = result.name;
                    dp.Text = result.datePurchased.ToShortDateString();
                    rdept.Text = result.receivingDept;
                    cp.Text = result.cost.ToString();
                    remark.Text = result.remark;
                    // string insuranceCode = result.insurance;
                    // var result2 = db.insuranceCompanies.Where(ic => ic.insuranceCode == insuranceCode).First();
                    ins.Text = result.insurance;
                    pnumber.Text = result.policyNumber;
                    sum.Text = result.sumInsured.ToString();
                    cdate.Text = result.coverDate.ToShortDateString();
                    edate.Text = result.expirydate.ToShortDateString();
                    if (result.status.Equals("active"))
                    {
                        status.Checked = true;
                    }
                    else
                    {
                        status.Checked = false; }
                }
                catch (Exception)
                {
                    msg.Text = "asset record not found";
                }
            }

        }

        protected void update_Click(object sender, EventArgs e)
        {
            try
            {
                string uname = Session["fullName"].ToString();
                string assetid = aid.Text;
                var result = db.assetRecords.Where(at => at.assetId == assetid).First();
                string name = result.name;
                string dept = result.receivingDept;
                string rem = result.remark;
                string sumins = result.sumInsured.ToString();
                string coverdate = result.coverDate.ToShortDateString();
                string expirydate = result.expirydate.ToShortDateString();
                string cstatus = result.status;
                var message = " An update occured on asset No:&nbsp;" + assetid + " by&nbsp;&nbsp;&nbsp;";
                message += uname + " Initial Record: Asset Name: " + name + ", Department: " + dept + ", Sum Insured" + sumins + ", Cover Date:" + coverdate + ", Expiry Date" + expirydate + ", Remark:" + rem + ", Status: " + status;
                message += "New Record: Asset Name:" + aname.Text + ", Department:" + rdept.Text + ",Sum Insured: " + sum.Text + "Cover Date:" + cdate.Text + "" + ", Expiry date" + edate.Text + ", Remark:" + remark.Text + ",Status:" + status.Text;

                var ar = db.assetRecords.FirstOrDefault(ai => ai.assetId == assetid);
                ar.name = aname.Text;
                ar.receivingDept = rdept.Text;
                ar.remark = remark.Text;
                if (status.Checked)
                {
                    ar.status = "active";
                }
                else { ar.status = "inactive"; }
               

                ar.datePurchased = DateTime.Parse(dp.Text);
                ar.cost = Convert.ToDecimal(cp.Text);
                ar.insurance = ins.Text;
                ar.policyNumber = pnumber.Text;
                ar.sumInsured = Convert.ToDecimal(sum.Text);
                ar.coverDate = DateTime.Parse(cdate.Text);
                ar.expirydate = DateTime.Parse(edate.Text);


                db.SaveChanges();

                assetUpdateHistory auh = new assetUpdateHistory();
                auh.assetId = assetid;
                auh.updateDate = DateTime.Now;
                auh.message = message;
                db.assetUpdateHistories.Add(auh);
                db.SaveChanges();
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Asset Updated Successfully... click OK to continue!"")</SCRIPT>"));
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""viewNiaAsset.aspx"") </SCRIPT>"));
               // msg.Text = "Record Updated Successfully";
            }
            catch (Exception)
            {
                msg.Text = "update failed";
            }
        }
    }
}