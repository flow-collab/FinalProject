using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using QueueCheckIns.Model;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
//using System.Web.Mvc;

namespace QueueCheckIn.Services
{
    public class RegisterRepository : IRegister
    {
        //    private readonly UserManager<IdentityUser> _userManager;
        //    public RegisterRepository(
        //        UserManager<IdentityUser> userManager)
        //    {
        //        _userManager = userManager;
        //    }

        //    public Register Add(Register newRegister)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            IdentityUser user = new IdentityUser()
        //            {
        //                Email = newRegister.Email,
        //                UserName = newRegister.Email
        //            };
        //            if(!string.IsNullOrEmpty(newRegister.BarberNumber))
        //            {
        //                user.Claims.Add(new IdentityUserClaim<string>
        //                {
        //                    ClaimType = "BarberNumber",
        //                    ClaimValue = newRegister.BarberNumber
        //                });
        //            }

        //            var result = await _userManager.CreateAsync(user, newRegister.Password);
        //            if (result.Succeeded)
        //            { return
        //            }
        //        }
        //    }
        public Register Add(Register newRegister)
        {
            throw new NotImplementedException();
        }
    }
}
