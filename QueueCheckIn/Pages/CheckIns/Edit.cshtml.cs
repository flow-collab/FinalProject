using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QueueCheckIns.Model;
using QueueCheckIn.Services;
using System.Net.Mail;
using System.Net;

namespace QueueCheckIn.Pages.CheckIns
{
    public class EditModel : PageModel
    {
        private readonly ICheckInRepository checkinRepository;

        public EditModel(ICheckInRepository checkinRepository)
        {
            this.checkinRepository = checkinRepository;
        }

        //private readonly IMailService _mailSender;
        //public EditModel(IMailService mailSender)
        //{
        //    _mailSender = mailSender;
        //}

        //[BindProperty]
        //public EmailMessage email { get; set; }

        [BindProperty]
        public CheckIn CheckIn { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                CheckIn = checkinRepository.GetCheckIn(id.Value);
            }
            else
            {
                CheckIn = new CheckIn();
            }

            if (CheckIn == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (CheckIn.Id > 0)
                {
                    CheckIn = checkinRepository.Update(CheckIn);
                    if (CheckIn.Status == Status.OnSiteWait)
                    {
                        Task t = Task.Run(async () =>
                        {
                            //_mailSender.Send(email);
                            var body = $@"{CheckIn.Name}, please make your way to the Barber Shop.";

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
                                msg.Body = body;
                                msg.Subject = "Please make your way to the baber shop";
                                msg.From = new MailAddress("capstonebarber@gmail.com");
                                msg.To.Add(CheckIn.PhoneNumber);
                                await smtp.SendMailAsync(msg);

                            }
                        });
                        t.Wait();
                        return RedirectToPage("Index");
                    }

                }
                else
                {
                    CheckIn = checkinRepository.Add(CheckIn);
                }

                return RedirectToPage("Index");
            }
            return Page();
        }

        
    }
}