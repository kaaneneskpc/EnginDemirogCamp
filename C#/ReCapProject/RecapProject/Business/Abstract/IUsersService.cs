using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUsersService
    {
        List<OperationClaim> GetClaims(Users user);
        void Add(Users user);
        Users GetByMail(string email);
    }
}
