using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Globalization;
using System.Net.Mail;

namespace niaps_ver_1._0.PrivateWeb
{
    public partial class createQuery : System.Web.UI.Page
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (natuerOfQuery.Text == string.Empty)
            {
                nqError.Text = "*";
                natuerOfQuery.Text = "";
            } else
                if (issuedBy.Text == string.Empty)
            {
                nqError.Text = "";
                issuedBy.Text = "";
                iError.Text = "*";
            }
                else
                    if (status.Text == "-select-")
                    {
                        statusError.Text = "*";
                        nqError.Text = "";
                        issuedBy.Text = "";
                        iError.Text = "";
                    }
            try
            {
                nqError.Text = "";
                iError.Text = "";
                statusError.Text = "";
                query iq = new query();
               
                iq.staffId = sid.SelectedValue;
                iq.natureOfQuery = natuerOfQuery.Text;
                iq.status = status.Text;
              //iq.actionTaken = "none";
                iq.issuedBy = issuedBy.Text;
                string result = dati.Text;
                //CultureInfo provider = new CultureInfo("en-US");
                //Thread.CurrentThread.CurrentCulture = provider;
                iq.dateIssued = DateTime.Parse(result);
                iq.index = 0;
                db.queries.Add(iq);
                db.SaveChanges();
                 natuerOfQuery.Text ="";
             //   action.Text="";
                issuedBy.Text = "";
                status.Text = "-select-";
                try
                {
                    string sId = sid.SelectedValue;
                    var fetchStaff = db.staffRecords.Where(fs => fs.staffId == sId).First();
                    string email = fetchStaff.email;
                    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                    mail.To.Add(email);
                    mail.From = new MailAddress("niaps.ver.1@gmail.com", "NIAPS", System.Text.Encoding.UTF8);
                    mail.Subject = "ATTENTION: You have a query";
                    mail.SubjectEncoding = System.Text.Encoding.UTF8;
                    mail.Body = "You have a query from:" + issuedBy.Text+". Please log in to <a href=\"Http://www.niaps.somee.com>\"NIAPS</a> and reply it. Thanks.";
                    mail.BodyEncoding = System.Text.Encoding.UTF8;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.High;
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new System.Net.NetworkCredential("niaps.ver.1@gmail.com", "niaps123");
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Send(mail);
                }catch(Exception){
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Query posted successfully... click OK to continue!"")</SCRIPT>"));
                    System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""createQuery.aspx"") </SCRIPT>"));
                }

                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(""Query posted successfully... click OK to continue!"")</SCRIPT>"));
                System.Web.HttpContext.Current.Response.Write(string.Format(@"<SCRIPT LANGUAGE=""JavaScript"">alert(window.location = ""createQuery.aspx"") </SCRIPT>"));
               // msg.Text = "Query posted successfully";
            }
            catch(Exception)
            {
                msg.Text = "Error, query failed";
            }
        }

        protected void sid_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sids = sid.SelectedValue;
            var detail = db.staffRecords.Where(de => de.staffId == sids).First();
            otherNames.Text = detail.fName + " &nbsp;&nbsp;&nbsp;" + detail.middleName + "   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbspId: " + detail.staffId;

        }

        protected void dati_TextChanged(object sender, EventArgs e)
        {
            if (dati.Text == string.Empty)
            {
                dati.Text = "";
                datiError.Text = "*";
            }
            try{
                DateTime qdate = DateTime.Parse(dati.Text);
                DateTime prsDate = DateTime.Now;
                int comp = qdate.Year - prsDate.Year;
                if (comp > 1)
                {
                    dati.Text = "";
                    datiError.Text = "*";
                }else if (comp < 0){
                    dati.Text = "";
                    datiError.Text = "*";
                
                }else if ((comp == 1)||(qdate.Month>prsDate.Month)){
                    dati.Text = "";
                    datiError.Text = "*";
                }
            }catch(Exception){
                dati.Text = "";
                datiError.Text = "*";
            }
        }
    }
}