﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
