using RDSAMR.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RDSAMR.Application.Interfaces
{
    public interface ISuperAdminService
    {
       LoginResultVM Login(UserLoginVM rec);
    
    }
}
