using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public abstract class Transporte
    {
        private int pasajeros { get; set; }
        public string name { get; set; }

        public Transporte (int pasajeros, string name)
        {
            this.pasajeros = pasajeros;
            this.name = name;
        }
        public abstract void Avanzar();
        

        public abstract void Detenerse();       
      
        public int getPasajeros()
        {
            return this.pasajeros;
        }
    }
    
    interface IVolador
    {
        void Volar();

    }

    interface ITocarBocina
    {
        void TocarBocina();
    }

}
