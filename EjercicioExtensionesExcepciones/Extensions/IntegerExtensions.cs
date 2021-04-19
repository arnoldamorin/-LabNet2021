using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionesExcepciones.Extensions
{
    public static class IntegerExtensions
    {
        public static int Dividir(this int i, int j)
        {
            return i / j;
        }

        public static int AlCuadrado(this int i)
        {
            return (int)Math.Pow(i, 2);
        }
    }
}
