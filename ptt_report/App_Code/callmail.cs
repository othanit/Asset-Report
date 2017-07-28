using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;

namespace ptt_report.App_Code
{
    public class callmail
    {
        public void CallMail(string email, string subject, string Detail)
        {

            MailMessage msg = new MailMessage();

            msg.To.Add(new MailAddress(email));

            msg.From = new MailAddress("ajn.ajn149@gmail.com"); // MailServer
            msg.Subject = subject;

            //'*** HTML Tag ***// 

            StringBuilder BD = new StringBuilder();
            BD.Append("<body>");
            BD.Append(Detail);
            BD.Append("</body>");

            msg.Body = BD.ToString();


            try
            {
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient();
                client.UseDefaultCredentials = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential("ajn.ajn149@gmail.com", "Admin2016");
                client.Timeout = 20000;

                client.Send(msg);

                //Mail.IsBodyHtml = true;
                //var Smtp = new System.Net.Mail.SmtpClient("122.154.24.29"); //'10.254.1.20
                //Smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                //Smtp.Credentials = new System.Net.NetworkCredential("webmaster@doae.go.th", "cntd0ae01W$");
                //Smtp.Send(Mail);

            }
            catch (Exception ex)
            {
                
            }
        }

        



    }
}