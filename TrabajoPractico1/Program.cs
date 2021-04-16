using System;
using System.Collections.Generic;

namespace TrabajoPractico1
{
    class Program
    {
        static void Main(string[] args)
        {           
          
            List<Transporte> transportes = new List<Transporte>();

            Random rnd = new Random();
           
            for (int i = 1; i < 6; i++)
            {
                transportes.Add(new Avion(rnd.Next(40, 100), $"Avión {i}"));              
            }
            for (int i = 1; i < 6; i++)            {
               
                transportes.Add(new Automovil(rnd.Next(1, 5), $"Automóvil {i}"));
            }

            foreach (var item in transportes)
            {
                Console.WriteLine($"{item.name}: { item.getPasajeros()} pasajeros");                
            }
            Automovil automovil6 = new Automovil(rnd.Next(1, 5), "Automóvil 6");
            automovil6.TocarBocina();
            Console.ReadLine();            
            
        }
    }
}
