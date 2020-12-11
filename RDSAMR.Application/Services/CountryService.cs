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
    public class CountryService:ICountryService
    {
        RDSAMRContext cntx;
        IMapper map;
        public CountryService(RDSAMRContext ctemp,IMapper mtemp)
        {
            this.cntx = ctemp;
            this.map = mtemp;
        }

        public void Add(CountryVM rec, long byid)
        {
            var crec = this.map.Map<Country>(rec);
            this.cntx.Countries.Add(crec);
            this.cntx.Commit(byid);
        }


        public void Delete(Int64 id, long byid)
        {
            var rec = this.cntx.Countries.Find(id);
            this.cntx.Countries.Remove(rec);
            this.cntx.Commit(byid);
        }

        public ICollection<CountryVM> GetAll()
        {
            var lst = this.map.Map<List<CountryVM>>(this.cntx.Countries.Where(p=>p.IsDeleted==false).AsNoTracking().ToList());
            return lst;
        }

        public CountryVM GetByID(long id)
        {
            var mrec =this.map.Map<CountryVM>(this.cntx.Countries.Find(id));
            return mrec;
        }

        public ICollection<CountryVM> GetByPredicate(Expression<Func<CountryVM, bool>> predicate)
        {
            var lst = this.map.Map<IQueryable<CountryVM>>(this.cntx.Countries.ToList());
            return lst.Where(predicate).ToList();
        }

       
        public void Update(CountryVM rec, long byid)
        {
            var crec = this.map.Map<Country>(rec);
            this.cntx.Entry(crec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cntx.Commit(byid);
        }

       

      
    }
}
