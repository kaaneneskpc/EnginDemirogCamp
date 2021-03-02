using Core.Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntitiyRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
