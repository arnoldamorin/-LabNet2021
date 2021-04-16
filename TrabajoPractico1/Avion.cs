using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public class Avion : Transporte, IVolador
    {
        public Avion(int pasajeros, string name) : base(pasajeros,name)
        {

        }    

        public override void Avanzar()
        {
            Console.WriteLine($"El {this.name} esta Avanzando hacia adelante para iniciar el despegue en \n 3 \n 2 \n 1 \n . . .");
            this.Volar();
        }
        public override void Detenerse()
        {
            Console.WriteLine("Me detuve");
        }

        public void Volar()
        {
            Console.WriteLine("Estoy Volando . . .");
        }
    }
}
