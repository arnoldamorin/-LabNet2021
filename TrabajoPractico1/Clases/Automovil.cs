using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Interfaces;

namespace TrabajoPractico1.Clases
{
    public class Automovil : Transporte, ITocarBocina
    {
        public Automovil(int pasajeros, string name) : base(pasajeros, name)
        {
            
        }
        public override void Avanzar()
        {
            Console.WriteLine($"El {this.name} Avanzando hacia adelante con {this.getPasajeros()} pasajeros");
        }
        public override void Detenerse()
        {
            Console.WriteLine($"El {this.name} detuve");
        }
        public void TocarBocina()
        {
            Console.WriteLine($"La Bocina del {this.name} es: ¡Piii piii!");
        }
    }
}
