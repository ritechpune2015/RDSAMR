using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RDSAMR.ASPNETCore.AuthFilter;

namespace RDSAMR.ASPNETCore.Areas.SuperAdmin.Controllers
{

    [SuperAdminAuth]
    [Area("SuperAdmin")]
    public class SuperAdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
