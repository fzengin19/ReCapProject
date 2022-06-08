using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    internal interface IColorService
    {
        IResult Add(Color Color);
        IResult Update(Color color);
        IResult Delete(Color color);
        IDataResult<Color> GetColorById(int colorId);
        IDataResult<List<Color>> GetColors();
    }
   
}
