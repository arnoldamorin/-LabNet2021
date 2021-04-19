using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionesExcepciones.Exceptions
{
    public class CustomException : Exception
    {
        
        public CustomException(string message) : base("Mensaje base de la Custom Exception: "+message)
        {

        }

    }
}
