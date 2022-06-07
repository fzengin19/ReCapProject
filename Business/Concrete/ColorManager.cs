using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _carColorService;
        public ColorManager(IColorDal carColorService)
        {
            _carColorService = carColorService;
        }

        public void Add(Color carColor)
        {
            _carColorService.Add(carColor);
        }

        public List<Color> GetColors()
        {
            return _carColorService.GetAll().ToList() ;
        }
    }
}
