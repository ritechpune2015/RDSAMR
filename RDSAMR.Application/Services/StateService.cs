using AutoMapper;
using RDSAMR.Application.Interfaces;
using RDSAMR.Application.ViewModels;
using RDSAMR.Domain.Entities;
using RDSAMR.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RDSAMR.Application.Services
{
    public class StateService:IStateService
    {
        RDSAMRContext cntx;
        IMapper map;
        public StateService(RDSAMRContext ctemp,IMapper mtemp)
        {
            this.cntx = ctemp;
            this.map = mtemp;
        }

        public void Add(StateVM rec, long byid)
        {
            var crec = this.map.Map<State>(rec);
            this.cntx.States.Add(crec);
            this.cntx.Commit(byid);
        }

        public void Delete(Int64 id, long byid)
        {
            var rec = this.cntx.States.Find(id);
            this.cntx.States.Remove(rec);
            this.cntx.Commit(byid);
        }

        public ICollection<StateVM> GetAll()
        {

            var lst = from t in this.cntx.States
                      where t.IsDeleted == false
                      select new StateVM
                      {
                          CountryName = t.Country.CountryName,
                          StateID = t.StateID,
                          StateName = t.StateName
                      };

           // var lst = this.map.Map<List<StateVM>>(this.cntx.States.Where(p => p.IsDeleted == false).AsNoTracking().ToList());
            return lst.ToList();
        }

        public StateVM GetByID(long id)
        {
            // var mrec =this.map.Map<StateVM>(this.cntx.States.Find(id));
            var mrec = this.GetAll().FirstOrDefault(p => p.StateID == id);
            return mrec;
        }

        public ICollection<StateVM> GetByPredicate(Expression<Func<StateVM, bool>> predicate)
        {
            var lst = this.map.Map<IQueryable<StateVM>>(this.cntx.Countries.ToList());
            return lst.Where(predicate).ToList();
        }

        public void Update(StateVM rec, long byid)
        {
            var crec = this.map.Map<State>(rec);
            this.cntx.Entry(crec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cntx.Commit(byid);
        }
    }
}
