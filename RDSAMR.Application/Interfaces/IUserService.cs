using RDSAMR.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RDSAMR.Application.Interfaces
{
    public interface IUserService
    {
        ICollection<CountryVM> GetAll();
        CountryVM GetByID(Int64 byid);
        void Add(CountryVM rec, Int64 byid);
        void Update(CountryVM rec, Int64 byid);
        void Delete(Int64 id, Int64 byid);
        ICollection<CountryVM> GetByPredicate(Expression<Func<CountryVM, bool>> predicate);
        LoginResultVM Login(UserLoginVM rec);
        ICollection<RoleVM> GetUserRoles(Int64 id);

    }
}
