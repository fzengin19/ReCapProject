using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        IColorDal _colorService;
        public ColorManager(IColorDal carColorService)
        {
            _colorService = carColorService;
        }

        public IResult Add(Color carColor)
        {
            _colorService.Add(carColor);
            return new SuccessResult(Messages.ColorAdded);
        }
        public IResult Update(Color carColor)
        {
            _colorService.Update(carColor);
            return new SuccessResult(Messages.ColorUpdated);
            
        }
        public IResult Delete(Color carColor)
        {
            _colorService.Delete(carColor);
            return new SuccessResult(Messages.ColorDeleted);
        }
        public IDataResult<Color> GetColorById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorService.Get(p => p.ColorId == colorId));
        }

        public IDataResult<List<Color>> GetColors()
        {
            return new SuccessDataResult<List<Color>>(_colorService.GetAll().ToList()) ;
        }
    }
}
