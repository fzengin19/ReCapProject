﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    internal interface IBrandService
    {
        void Add(Brand brand);
        List<Brand> GetBrands();
    }
}