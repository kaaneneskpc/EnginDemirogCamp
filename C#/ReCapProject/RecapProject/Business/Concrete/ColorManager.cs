using Business.Abstract;
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

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
        public List<Color> GetById(int id)
        {
            return _colorDal.GetAll(c => c.ColorId == id);
        }

        public List<ColorDetailDto> GetColorDetails()
        {
            throw new NotImplementedException();
        }
    }
}
