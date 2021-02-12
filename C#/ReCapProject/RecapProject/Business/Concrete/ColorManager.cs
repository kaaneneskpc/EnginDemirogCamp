using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
            
        }
        public IDataResult<List<Color>> GetById(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c => c.ColorId == id));
            
        }

        public IDataResult<List<ColorDetailDto>> GetColorDetails()
        {
            return new SuccessDataResult<List<ColorDetailDto>>(_colorDal.GetColorDetails());
        }
    }
}
