using RDSAMR.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RDSAMR.Application.Interfaces
{
    public interface ICityService
    {
        ICollection<CityVM> GetAll();
        CityVM GetByID(Int64 byid);
        void Add(CityVM rec, Int64 byid);
        void Update(CityVM rec, Int64 byid);
        void Delete(Int64 id, Int64 byid);
        ICollection<CityVM> GetByPredicate(Expression<Func<CityVM, bool>> predicate);
    }
}
