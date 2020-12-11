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
                    return RedirectToAction("SelectRole");
                }

                ModelState.AddModelError("", "Invalid Email ID or Password!");

            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult SelectRole()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var roles = this.usersvr.GetUserRoles(userid);
            ViewBag.Roles = new SelectList(roles,"RoleName","RoleName");
            return View();
        }

        [HttpPost]
        public IActionResult SelectRole(RoleVM rec)
        {
            if (ModelState.IsValid)
            {
                switch (rec.RoleName)
                {
                    case "SuperAdmin":
                        return RedirectToAction("Index", "SuperAdminHome", new { area = "SuperAdmin" });
                    case "Admin":
                        return RedirectToAction("Index", "AdminHome", new { area = "Admin" });
                    case "Staff":
                        return RedirectToAction("Index", "StaffHome", new { area = "Staff" });
                    default:
                        ModelState.AddModelError("RoleName", "Please Select Role");
                        return View();
                }
            }

            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var roles = this.usersvr.GetUserRoles(userid);
            ViewBag.Roles = new SelectList(roles, "RoleID", "RoleName");
            return View();
        }
    }
}
