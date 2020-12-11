using RDSAMR.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RDSAMR.Application.Interfaces
{
    public interface IStateService
    {
        ICollection<StateVM> GetAll();
        StateVM GetByID(Int64 byid);
        void Add(StateVM rec, Int64 byid);
        void Update(StateVM rec, Int64 byid);
        void Delete(Int64 id, Int64 byid);
        ICollection<StateVM> GetByPredicate(Expression<Func<StateVM, bool>> predicate);
    }
}
