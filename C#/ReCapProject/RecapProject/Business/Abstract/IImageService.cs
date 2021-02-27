using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Entities.DTOs;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IImageService
    {
        IResult Add(IFormFile file, Image image);
        IResult Update(IFormFile file, Image image);
        IResult Delete(IFormFile file, Image image);
        IDataResult<List<Image>> GetAll(Expression<Func<Image, bool>> filter = null);
        IDataResult<Image> GetById(int id);

    }
}
