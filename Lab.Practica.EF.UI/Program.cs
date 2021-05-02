using Lab.Practica.EF.Entities;
using Lab.Practica.EF.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //TerritoriesLogic territoriesLogic = new Logic.TerritoriesLogic();
            ////Agregar
            //territoriesLogic.Add(new Territories
            //{
            //    TerritoryID = "21458",
            //    TerritoryDescription = "Descripcion 1",
            //    RegionID = 1
            //});
            //// Eliminar
            //territoriesLogic.Delete(21458);
            //// Actualizar
            //territoriesLogic.Update(new Territories
            //{
            //    TerritoryID = "21458",
            //    TerritoryDescription = "Nueva Descripcion",
            //    RegionID = 2
            //});       
            ////Mostrar
            //Console.WriteLine("{0,5} {1,5} {2,40}", "Id", "Descripcion", "Region");
            //foreach (Territories territories in territoriesLogic.GetAll())
            //{
            //    Console.WriteLine("{0,5} {1,5}  {2,0}", territories.TerritoryID, territories.TerritoryDescription, territories.RegionID);
            //}
            //Console.ReadKey();
            #endregion
            ShippersLogic shippersLogic = new ShippersLogic();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("{0,5} {1,5} {2,20}", "Id", "Compañia", "Telefono");
            foreach (Shippers shippers in shippersLogic.GetAll())
            {
                Console.WriteLine("{0,5} {1,5} {2,20}", shippers.ShipperID, shippers.CompanyName, shippers.Phone);
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            //Menu menuPrincipal = new Menu();

            //menuPrincipal.MenuPrincipal();
        }
    }
}
