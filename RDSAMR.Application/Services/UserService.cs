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
    public class UserService : IUserService
    {
        RDSAMRContext cntx;
        public UserService(RDSAMRContext temp)
        {
            this.cntx = temp;
        }

        public void Add(CountryVM rec, long byid)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id, long byid)
        {
            throw new NotImplementedException();
        }

        public ICollection<CountryVM> GetAll()
        {
            throw new NotImplementedException();
        }

        public CountryVM GetByID(long byid)
        {
            throw new NotImplementedException();
        }

        public ICollection<CountryVM> GetByPredicate(Expression<Func<CountryVM, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        

        public LoginResultVM Login(UserLoginVM rec)
        {
            var urec = this.cntx.Users.SingleOrDefault(p => p.EmailID == rec.EmailID && p.PasswordHash == rec.Password);
            LoginResultVM logresult = null;
            if (urec != null)
            {
                logresult = new LoginResultVM();
                logresult.UserID = urec.UserID;
                logresult.UserName = urec.FirstName+" " + urec.LastName;
                logresult.RoleName = urec.Role.RoleName;
             }
            return logresult;
        }

        public void Update(CountryVM rec, long byid)
        {
            throw new NotImplementedException();
        }
    }
}
