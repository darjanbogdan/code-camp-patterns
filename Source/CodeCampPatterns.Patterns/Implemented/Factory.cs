﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public abstract class Factory
    {
        public abstract Car CreateCar(MercedesSeries series);
    }
}
