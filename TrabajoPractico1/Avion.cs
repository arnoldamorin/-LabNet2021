using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public class Avion : Transporte
    {
        public Avion(int pasajeros) : base(pasajeros)
        {

        }

        public override string Avanzar(int cantidad)
        {
            throw new NotImplementedException();
        }
        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
