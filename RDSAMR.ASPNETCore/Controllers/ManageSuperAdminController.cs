using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RDSAMR.Application.Interfaces;
using RDSAMR.Application.Services;
using RDSAMR.Application.ViewModels;

namespace RDSAMR.ASPNETCore.Controllers
{
    public class ManageSuperAdminController : Controller
    {
        ISuperAdminService usersvr;
        
        public ManageSuperAdminController(ISuperAdminService utemp)
        {
            this.usersvr = utemp;
        }

        [HttpGet]
        public IActionResult doLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult doLogin(UserLoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var r = this.usersvr.Login(rec);
                if (r != null)
                {
                    HttpContext.Session.SetString("SuperAdminID",r.UserID.ToString());
                    HttpContext.Session.SetString("SuperAdminName", r.UserName);
                    return RedirectToAction("Index", "SuperAdminHome", new { area = "SuperAdmin" });
                }
                ModelState.AddModelError("", "Invalid Email ID or Password!");
            }
            return View(rec);
        }
    }
}
