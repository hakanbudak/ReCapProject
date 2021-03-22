using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
     public interface IUserService      
    {
        IDataResult<List<User>> GetAll();

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
