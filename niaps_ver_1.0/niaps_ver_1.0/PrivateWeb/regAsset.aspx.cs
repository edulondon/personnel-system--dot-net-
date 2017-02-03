using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Globalization;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class regAsset : System.Web.UI.Page
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

        protected void register_Click(object sender, EventArgs e)
        {
            try
            {
                assetRecord ar = new assetRecord();
                if (dateP.Text == string.Empty)
                {
                    dError.Text = "*";
                }
                else
                    if (aname.Text == string.Empty)
                    {
                        aError.Text = "*";
                    }
                    else
                        if (aid.Text == string.Empty)
                        {
                            assetError.Text = "*";
                        }
                        else if (pnumber.Text == string.Empty)
                        {
                            ipError.Text = "*";
                        }
                        else if (sum.Text == string.Empty)
                        {
                            siError.Text = "*";
                        }
                        else if (ven.Text == string.Empty)
                        {
                            vendorError.Text = "*";
                        }
                        else if (remark.Text == string.Empty)
                        {
                            remarkError.Text = "*";
                        }
                        else if (rdept.Text == string.Empty)
                        {
                            rdError.Text = "*";
                        }
                        else if (cp.Text == string.Empty)
                        {
                            copError.Text = "*";
                        }
                        else if (status.Text == string.Empty)
                        {
                            statusError.Text = "*";
                        }
                        else
                        {
                            ar.assetId = aid.Text;
                            ar.name = aname.Text;
                            DateTime result;
                            CultureInfo provider = new CultureInfo("en-US");
                            Thread.CurrentThread.CurrentCulture = provider;
                            result = DateTime.Parse(dateP.Text);
                            ar.datePurchased = result;
                            ar.receivingDept = rdept.Text;
                            Double intValue = Double.Parse(cp.Text);
                            string html = (intValue.ToString("N2", CultureInfo.InvariantCulture));
                            ar.cost = Convert.ToDecimal(html);
                            ar.remark = remark.Text;
                            ar.insurance = insurance.SelectedValue;
                            ar.policyNumber = pnumber.Text;
                            Double intVal = Double.Parse(sum.Text);
                            string htmlSumIn = (intVal.ToString("N2", CultureInfo.InvariantCulture));
                            ar.sumInsured = Convert.ToDecimal(htmlSumIn);
                            DateTime result2 = DateTime.Parse(edate.Text);
                            ar.expirydate = result2;
                            DateTime result3 = DateTime.Parse(cdate.Text);
                            ar.coverDate = result3;
                            ar.vendor = ven.Text;
                            ar.status = status.Text;
                            db.assetRecords.Add(ar);
                            db.SaveChanges();
                            System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Asset Registered Successfully... click OK to continue!"")</SCRIPT>"));
                            System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""regAsset.aspx"") </SCRIPT>"));
                            cp.Text = "";
                            sum.Text = "";
                            pnumber.Text = "";
                            remark.Text = "";
                            rdept.Text = "";
                            status.Text = "";
                            ven.Text = "";
                            remark.Text = "";
                            aid.Text = "";
                            aname.Text = "";
                            dateP.Text = "";
                            edate.Text = "";
                            cdate.Text = "";
                           
                          //  msg.Text = "Asset Registered Successfully";
                        }
            }
            catch (Exception)
            {
                msg.Text = "1 or 2 fields are empty";
            }
        }

        protected void edate_TextChanged(object sender, EventArgs e)
        {
            dateError.Text = "";
            dateError2.Text = "";
            dError.Text = "";
            if (cdate.Text == string.Empty)
            {
                dateError.Text = "*";
            }
            if (edate.Text == string.Empty)
            {
                dateError2.Text = "*";
            }
            else
            {
                try
                {
                    DateTime coverD = DateTime.Parse(cdate.Text);
                    DateTime expiryD = DateTime.Parse(edate.Text);
                    DateTime Pdate = DateTime.Parse(dateP.Text);
                    //int pd = Pdate.Year;
                    //int cd = coverD.Year;
                    int i = expiryD.Year - coverD.Year;
                    //if (i < 1)
                    //{
                    //    dateError2.Text = "invalid date";
                    //    dateError.Text = "";
                    //    dError.Text = "";
                    //    edate.Text = "";
                    //}
                    if (i > 1)
                    {
                        dateError2.Text = "invalid date";
                        dateError.Text = "";
                        dError.Text = "";
                        edate.Text = "";
                    }
                    if (Pdate > coverD)
                    {
                        dateError.Text = "invalid date";
                        dError.Text = "";
                        dateError2.Text = "";
                        edate.Text = "";
                    }

                }
                catch (Exception)
                {
                    dError.Text = "";
                    edate.Text = "";
                    dateError2.Text = "invalid date";
                }
            }
        }

        protected void cp_TextChanged(object sender, EventArgs e)
        {
            dError.Text = "";
            copError.Text = "";
            dateError2.Text = "";
            try
            {
                if (char.IsNumber(cp.Text, 0))
                {

                }
                else
                {
                    copError.Text = "enter numeric/decimal value";

                }
            }
            catch (Exception) { copError.Text = "enter numeric/decimal value"; }
        }

        protected void sum_TextChanged(object sender, EventArgs e)
        {
            dError.Text = "";
            copError.Text = "";
            dateError2.Text = "";
            siError.Text = "";
            try
            {
                if (char.IsNumber(cp.Text, 0))
                {

                }
                else
                {
                    siError.Text = "enter numeric/decimal value";

                }
            }
            catch (Exception) { siError.Text = "enter numeric/decimal value"; }
        }

        protected void dateP_TextChanged(object sender, EventArgs e)
        {
            dError.Text = "";
            copError.Text = "";
            dateError2.Text = "";
            dError.Text = "";
            string datePurchased = dateP.Text;
            try
            {
                DateTime dateOptained = DateTime.Parse(datePurchased);
                DateTime current = DateTime.Now;
                if (dateOptained.Year > current.Year)
                {
                    dError.Text = "invalid date";
                    dateP.Text = "";
                }
                if ((dateOptained.Year == current.Year) && (dateOptained.Month > current.Month))
                {
                    dError.Text = "invalid date";
                    dateP.Text = "";
                }
            }
            catch (Exception) { dError.Text = "invalid date"; dateP.Text = ""; }
        }

        protected void cdate_TextChanged(object sender, EventArgs e)
        {
            string coverDate = cdate.Text;
            string datePurchase = dateP.Text;
            try
            {
                DateTime cover = DateTime.Parse(coverDate);
                DateTime dateOptained = DateTime.Parse(datePurchase);
                
                if (cover.Year > dateOptained.Year)
                {
                    dateError.Text = "invalid date";
                    dateError2.Text = "";
                    cdate.Text="";
                }
                if ((cover.Year == dateOptained.Year) && (cover.Month < dateOptained.Month))
                {
                    dateError.Text = "invalid date";
                    dateError2.Text = "";
                    cdate.Text = "";
                }
                if ((cover.Year == dateOptained.Year) && (cover.Month == dateOptained.Month) && (cover.Day < dateOptained.Day)) 
                {
                    dateError.Text = "invalid date";
                    dateError2.Text = "";
                    cdate.Text = "";
                }
            }
            catch (Exception) { dateError.Text = "invalid date"; cdate.Text = ""; }
        }

        
        
    }
}