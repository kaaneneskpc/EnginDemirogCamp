using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UsersManager : IUsersService
    {
        IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public List<OperationClaim> GetClaims(Users user)
        {
            return _usersDal.GetClaims(user);
        }

        public void Add(Users user)
        {
            _usersDal.Add(user);
        }

        public Users GetByMail(string email)
        {
            return _usersDal.Get(u => u.Email == email);
        }
    }
}
