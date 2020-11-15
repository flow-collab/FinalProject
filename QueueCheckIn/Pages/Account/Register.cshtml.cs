using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QueueCheckIns.Model;

namespace QueueCheckIn.Pages.Account
{
    public class RegisterModel : PageModel
    {

        [BindProperty]
        public Register Register { get; set; }

        private readonly UserManager<IdentityUser> _userManager;

        public RegisterModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser()
                {
                    Email = Register.Email,
                    UserName = Register.Email
                };

                //if (!string.IsNullOrEmpty(model.BarberNumber))
                //{
                //    user.Claims.Add(new IdentityUserClaim<string>
                //    {
                //        ClaimType = "FacultyNumber",
                //        ClaimValue = model.BarberNumber
                //    });
                //}

                var result = await _userManager.CreateAsync(user, Register.Password);

                if (result.Succeeded)
                {
                    return RedirectToPage("/Account/Login");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
