using RDSAMR.Application.Interfaces;
using RDSAMR.Application.ViewModels;
using RDSAMR.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RDSAMR.Application.Services
{
    public class SuperAdminService : ISuperAdminService
    {
        RDSAMRContext cntx;
        public SuperAdminService(RDSAMRContext temp)
        {
            this.cntx = temp;
        }

        public LoginResultVM Login(UserLoginVM rec)
        {
            var urec = this.cntx.SuperAdmins.SingleOrDefault(p => p.EmailID == rec.EmailID && p.PasswordHash == rec.Password);
            LoginResultVM logresult = null;
            if (urec != null)
            {
                logresult = new LoginResultVM();
                logresult.UserID = urec.SuperAdminID;
                logresult.UserName = urec.Name;
             }
            return logresult;
        }

    }
}
