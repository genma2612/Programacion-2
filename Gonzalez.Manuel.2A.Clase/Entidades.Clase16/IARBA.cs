﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase16
{
    public interface IARBA
    {
        double PorcentajeARBA { get; }

        double CalcularImpuesto();
    }
}
