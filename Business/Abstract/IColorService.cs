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
        public void Add(Color carColor);
        List<Color> GetColors();
    }
}
