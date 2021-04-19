using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Clases;

namespace TrabajoPractico1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Transporte> transportes = new List<Transporte>();

            Random rnd = new Random();
            // Lo resolvi asi por una cuestion estetica de que se vea igual al pdf del TP
            for (int i = 1; i < 6; i++)
            {
                transportes.Add(new Avion(rnd.Next(40, 100), $"Avión {i}"));
            }
            for (int i = 1; i < 6; i++)
            {

                transportes.Add(new Automovil(rnd.Next(1, 5), $"Automóvil {i}"));
            }

            foreach (var item in transportes)
            {
                Console.WriteLine($"{item.name}: { item.getPasajeros()} pasajeros");
            }

            //Ejemplo de uso de las interfaces
            Automovil automovil6 = new Automovil(rnd.Next(1, 5), "Automóvil 6");
            automovil6.TocarBocina();

            Avion avion6 = new Avion(rnd.Next(20, 100), "Avión 5");
            avion6.Volar();


        }
    }
