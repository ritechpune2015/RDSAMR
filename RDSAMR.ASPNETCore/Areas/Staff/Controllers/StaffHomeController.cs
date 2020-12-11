using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RDSAMR.ASPNETCore.AuthFilter;

namespace RDSAMR.ASPNETCore.Areas.Staff.Controllers
{
    [UserAuth]
    [Area("Staff")]
    public class StaffHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
