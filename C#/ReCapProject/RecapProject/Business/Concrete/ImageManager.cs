using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public IResult Add(IFormFile file, Image image)
        {
            var result = BusinessRules.Run(CheckCarImageLimit(image));

            if (result != null)
            {
                return result;
            }

            image.ImagePath = FileHelper.AddAsync(file);
            image.ImageDate = DateTime.Now;
            _imageDal.Add(image);

            return new SuccessResult(Messages.AddedImage);
        }

        public IResult Delete(IFormFile file, Image image)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) 
                + _imageDal.Get(i => i.ImageId == image.ImageId).ImagePath;

            var result = BusinessRules.Run(FileHelper.DeleteAsync(oldpath));

            if (result != null)
            {
                return result;
            }

            _imageDal.Delete(image);
            return new SuccessResult(Messages.DeletedImage);
        }

        public IDataResult<List<Image>> GetAll(Expression<Func<Image, bool>> filter = null)
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll(filter));
        }

        public IDataResult<Image> GetById(int id)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(i => i.ImageId == id));
        }

        public IResult Update(IFormFile file, Image image)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) +
                _imageDal.Get(p => p.ImageId == image.ImageId).ImagePath;
            image.ImagePath = FileHelper.UpdateAsync(oldpath, file);
            image.ImageDate = DateTime.Now;
            _imageDal.Update(image);
            return new SuccessResult();
        }

        private IResult CheckCarImageLimit(Image image)
        {
            if (_imageDal.GetAll(c => c.CarId == image.CarId).Count >= 5)
            {
                return new ErrorResult(Messages.FailedImageAdd);
            }

            return new SuccessResult();
        }
    }
}
