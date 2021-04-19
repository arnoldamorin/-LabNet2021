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
            if (j == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return i / j;
            }
        }
    }
}
