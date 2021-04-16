using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public abstract class Transporte
    {
        private int pasajeros { get; }

        public Transporte (int pasajeros)
        {
            this.pasajeros = pasajeros;
        }
        public abstract bool Avanzar();
       

        public abstract bool Detenerse();
       
    }
}
