using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace QueueCheckIn.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            string returnUrl = null;
            ViewData["ReturnURL"] = returnUrl;
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(Email, Password, RememberMe, lockoutOnFailure: false);
                
                if(result.Succeeded)
                { 
                    if(Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToPage("/Employee/Index");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt");
                }
            }
            return Page();
            //var isValidUser =
            //    EmailAddress == "admincapstonebarber@gmail.com"
            //    && Password == "topsecret!";

            //if (!isValidUser)
            //{
            //    ModelState.AddModelError("", "Invalid username or password.");
            //}

            //if(!ModelState.IsValid)
            //{
            //    return Page();
            //}


            //var scheme = CookieAuthenticationDefaults.AuthenticationScheme;

            //var user = new ClaimsPrincipal(
            //    new ClaimsIdentity(
            //        new[] { new Claim(ClaimTypes.Name, EmailAddress) },
            //        scheme));

            //return SignIn(user, scheme);
        }

        public async Task<IActionResult> OnPostLogoutAsync()
        {

            await _signInManager.SignOutAsync();
            return RedirectToPage("/Account/LogIn");
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //return RedirectToPage("/CheckIns/Add");
        }
    }
}
