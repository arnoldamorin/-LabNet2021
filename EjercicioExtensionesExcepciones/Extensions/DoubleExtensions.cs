using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionesExcepciones.Extensions
{
    public static class DoubleExtensions
    {
        public static double Dividir(this double i, double j)
        {
            return i / j;
        }
    }
}
