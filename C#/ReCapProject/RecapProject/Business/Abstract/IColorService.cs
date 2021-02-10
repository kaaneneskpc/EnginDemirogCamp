using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();

        List<Color> GetById(int id);

        List<ColorDetailDto> GetColorDetails();
    }
}
