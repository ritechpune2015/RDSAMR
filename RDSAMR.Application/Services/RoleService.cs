using AutoMapper;
using RDSAMR.Application.Interfaces;
using RDSAMR.Application.ViewModels;
using RDSAMR.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDSAMR.Application.Services
{
    public class RoleService : IRoleService
    {
        RDSAMRContext cntx;
        IMapper map;
        public RoleService(RDSAMRContext temp,IMapper mtemp)
        {
            this.cntx = temp;
            this.map = mtemp;
        }
        public ICollection<RoleVM> GetAll()
        {
            var r= this.map.Map<ICollection<RoleVM>>(this.cntx.Roles.ToList());
            return r;
        }
    }
}
