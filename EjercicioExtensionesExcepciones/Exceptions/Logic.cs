using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionesExcepciones.Exceptions
{
    public class Logic
    {
        public static void Ejercicio3()
        {
            DateTime? fechaConValorNull = null;
            string fechaFormateada = fechaConValorNull.Value.ToString("MM/yy");
        }

        public static void ThrowCustomException()
        {
            throw new CustomException();
        }
    }
}
