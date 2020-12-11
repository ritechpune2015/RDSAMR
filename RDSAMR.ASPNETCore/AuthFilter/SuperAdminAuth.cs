using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDSAMR.ASPNETCore.AuthFilter
{
    public class SuperAdminAuth : ActionFilterAttribute, IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.Get("SuperAdminID")==null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "doLogin", controller = "ManageSuperAdmin", area = "" }));
            }
        }
    }
}
