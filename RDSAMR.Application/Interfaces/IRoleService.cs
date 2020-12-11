using RDSAMR.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RDSAMR.Application.Interfaces
{
    public interface IRoleService
    {
        ICollection<RoleVM> GetAll();
        //RoleVM GetByID(Int64 byid);
        //void Add(RoleVM rec, Int64 byid);
        //void Update(RoleVM rec, Int64 byid);
        //void Delete(Int64 id, Int64 byid);
        //ICollection<RoleVM> GetByPredicate(Expression<Func<RoleVM, bool>> predicate);
    }
}
