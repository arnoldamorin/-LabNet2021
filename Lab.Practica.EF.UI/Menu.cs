using Lab.Practica.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.EF.UI
{
    public class Menu
    {
        public void MenuPrincipal()
        {
            int opcion = 0;
            SubMenu subMenu = new SubMenu();      
            do
            {
                Console.Clear();
                Console.WriteLine("-------- Menú Principal --------");
                Console.WriteLine("Entidades" +
                    "\n 1.- Shippers" +
                    "\n 2.- Territories"+                  
                    "\n 3.- Salir");              
                Console.WriteLine("Elije una opción para Altas,Bajas o Modificaciones");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:                        
                        subMenu.MenuABM("ShippersLogic");
                        break;
                    case 2:
                        subMenu.MenuABM("TerritoriesLogic");
                        break;                
                    case 3:
                        opcion = 3;
                        break;
                }
            } while (opcion != 3);
            
        }
    }
}

