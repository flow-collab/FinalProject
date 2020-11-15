using QueueCheckIns.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace QueueCheckIn.Services
{
    public class MailService : IMailService
    {
        public async Task Send(EmailMessage emailMessage)
        {
            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "capstonebarber@gmail.com",
                    Password = "CAPstone1"
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                var msg = new MailMessage();
                msg.Body = "You are next in line for your barber appointment.  Can you please make your way to the barber shop.";
                msg.Subject = "Please make your way to the baber shop";
                msg.From = new MailAddress("capstonebarber@gmail.com");
                msg.To.Add("capstonebarber@gmail.com");
                    //(emailMessage.To);
                await smtp.SendMailAsync(msg);
            }
        }
    }
}
