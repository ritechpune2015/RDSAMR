﻿using System;
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
    public class ManageUsersController : Controller
    {
        IUserService usersvr;
        IRoleService rolessvr;
        public ManageUsersController(IUserService utemp,IRoleService rtemp)
        {
            this.usersvr = utemp;
            rolessvr = rtemp;
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
                    HttpContext.Session.SetString("UserID",r.UserID.ToString());
                    HttpContext.Session.SetString("UserName", r.UserName);
                    if (r.RoleName == "Admin")
                        return RedirectToAction("Index", "AdminHome", new { area = "Admin" });
                    if (r.RoleName == "Staff")
                        return RedirectToAction("Index", "StaffHome", new { area = "Staff" });
                }

                ModelState.AddModelError("", "Invalid Email ID or Password!");

            }
            return View(rec);
        }

       
    }
}
