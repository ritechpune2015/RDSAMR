using AutoMapper;

using Microsoft.EntityFrameworkCore;
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
    public class CityService:ICityService
    {
        RDSAMRContext cntx;
        IMapper map;
        public CityService(RDSAMRContext ctemp,IMapper mtemp)
        {
            this.cntx = ctemp;
            this.map = mtemp;
        }

        public void Add(CityVM rec, long byid)
        {
            var crec = this.map.Map<City>(rec);
            this.cntx.Cities.Add(crec);
            this.cntx.Commit(byid);
        }

        public void Delete(Int64 id, long byid)
        {
            var rec = this.cntx.Cities.Find(id);
            this.cntx.Cities.Remove(rec);
            this.cntx.Commit(byid);
        }

        public ICollection<CityVM> GetAll()
        {

            var lst = from t in this.cntx.Cities
                      where t.IsDeleted == false
                      select new CityVM
                      {
                          CityID =t.CityID,
                          StateName = t.State.StateName,
                          StateID = t.StateID,
                          CityName = t.CityName
                      };

           // var lst = this.map.Map<List<StateVM>>(this.cntx.States.Where(p => p.IsDeleted == false).AsNoTracking().ToList());
            return lst.ToList();
        }

        public CityVM GetByID(long id)
        {
            // var mrec =this.map.Map<StateVM>(this.cntx.States.Find(id));
            var mrec = this.GetAll().FirstOrDefault(p => p.CityID == id);
            return mrec;
        }

        public ICollection<CityVM> GetByPredicate(Expression<Func<CityVM, bool>> predicate)
        {
            var lst = this.map.Map<IQueryable<CityVM>>(this.cntx.Cities.ToList());
            return lst.Where(predicate).ToList();
        }

        public void Update(CityVM rec, long byid)
        {
            var crec = this.map.Map<City>(rec);
            this.cntx.Entry(crec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cntx.Commit(byid);
        }
    }
}
