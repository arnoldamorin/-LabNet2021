using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioExtensionesExcepciones.Extensions;

namespace EjercicioExtensionesExcepciones.Exceptions
{
    public class Logic
    {
        public static void Ejercicio3()
        {
            var numeros = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (var n in numeros)
            {
                int cuadrado = n.AlCuadrado();                
                numeros.Add(cuadrado);
            }
        }

        public static void Ejercicio4()
        {
            throw new CustomException("Mensaje personalizado");
        }
    }
}
