using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace WindowsChatApplication
{
    class sendEmail
    {
        public static void sendMessage(string emailAddr, string passW)
        {
            /// 
            ///<summary>
            ///Violently stolen from:  https://github.com/cosullivan/SmtpServer
            ///By the way; NuGet is strange, but it works!
            ///</summary>
            //
            try
            {
                var fromAddress = new MailAddress("christopherjrupert@gmail.com", "From Admin");
                var toAddress = new MailAddress(emailAddr, "To " + emailAddr.Substring(0, emailAddr.IndexOf("@")));

                const string subject = "Welcome to windows chat Application!";

                //formatted body for html
                string body = "<HTML>" +
                    "<BODY>" +
                    "<h1>Hello!</h1>" +
                    "<p>You're all ready to login!  You just need to make sure that you use your password to login :)</p>" +
                    "<p><b style=\"color: #4286f4;\">Email: " + emailAddr + "</b></p>" +
                    "<p><b style=\"color: #4286f4;\">Password: " + passW + "</b></p>" +
                    "</BODY></HTML>";
                //it's pretty.

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.EnableSsl = true;
                

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    message.IsBodyHtml = true;
                    smtp.Send(message);
                    smtp.Dispose();
                }
                

            } catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }
    }
}
