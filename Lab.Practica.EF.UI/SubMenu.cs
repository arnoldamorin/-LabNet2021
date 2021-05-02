using Lab.Practica.EF.Entities;
using Lab.Practica.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.EF.UI
{
    public class SubMenu
    {
        public void MenuABM(string Entidad)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-------- Menú ABM -------");
                Console.WriteLine($"Estamos en la entidad {Entidad}"+
                    "\n 1.- Alta" +
                    "\n 2.- Baja" +
                    "\n 3.- Modificaciones" +
                    "\n 4.- Ver tabla" +
                    "\n 5.- Volver");
                Console.WriteLine("Elije una opción");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        if (Entidad == "ShippersLogic")
                        {                           
                            Console.WriteLine("Ingrese Nombre de la Compañia");
                            string compañia = Console.ReadLine();
                            Console.WriteLine("Ingrese Numero de Telefono");
                            string telefono = Console.ReadLine();
                            try
                            {
                                shippersLogic.Add(new Shippers
                                {
                                    CompanyName = compañia,
                                    Phone = telefono
                                });
                                Mensaje("Agregado");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Mensaje Exception: {ex.Message}");
                            }                          
                        }
                        else
                        {
                            if (Entidad == "TerritoriesLogic")
                            {                               
                                Console.WriteLine("Ingrese el ID");
                                string id = Console.ReadLine();
                                Console.WriteLine("Ingrese Descripción");
                                string descripcion = Console.ReadLine();
                                Console.WriteLine("Ingrese Numero de Region");
                                int idregion = Convert.ToInt32(Console.ReadLine());
                                try
                                {
                                    territoriesLogic.Add(new Territories
                                    {
                                        TerritoryDescription = descripcion,
                                        TerritoryID = id,
                                        RegionID = idregion
                                    });
                                    Mensaje("Agregado");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Mensaje Exception{ex.Message}");
                                    Console.ReadKey();
                                }                                                        
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        if (Entidad == "ShippersLogic")
                        {
                            Console.WriteLine("Ingrese el ID a Eliminar");
                            int id = Convert.ToInt32(Console.ReadLine());
                            try{
                                shippersLogic.Delete(id);
                                Mensaje("Eliminado");
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine($"Mensaje Exception{ex.Message}");    
                            }                            
                        }
                        else
                        {
                            if (Entidad == "TerritoriesLogic")
                            {
                                Console.WriteLine("Ingrese el ID a Eliminar");
                                int id = Convert.ToInt32(Console.ReadLine());
                                try
                                {
                                    territoriesLogic.Delete(id);
                                    Mensaje("Eliminado");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Mensaje Exception{ex.Message}");
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        if (Entidad == "ShippersLogic")
                        {
                            Console.WriteLine("Ingrese el ID a Actualizar");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese Nombre de la Compañia");
                            string compañia = Console.ReadLine();
                            Console.WriteLine("Ingrese Numero de Telefono");
                            string telefono = Console.ReadLine();
                            try
                            {
                                shippersLogic.Update(new Shippers
                                {
                                    ShipperID = id,
                                    CompanyName = compañia,
                                    Phone = telefono
                                });
                                Mensaje("Actualizado");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Mensaje Exception{ex.Message}");
                            }                            
                        }
                        else
                        {
                            if (Entidad == "TerritoriesLogic")
                            {
                                Console.WriteLine("Ingrese el ID a Actualizar");
                                string id = Console.ReadLine();
                                Console.WriteLine("Ingrese Descripción");
                                string descripcion = Console.ReadLine();
                                Console.WriteLine("Ingrese Numero de Region");
                                int idregion = Convert.ToInt32(Console.ReadLine());
                                try
                                {
                                    territoriesLogic.Update(new Territories
                                    {
                                        TerritoryID = id,
                                        TerritoryDescription = descripcion,                                       
                                        RegionID = idregion
                                    });
                                    Mensaje("Actualizado");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Mensaje Exception{ex.Message} - {ex.StackTrace}");
                                    Console.ReadKey();
                                }
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        if (Entidad == "ShippersLogic")
                        {
                            MostrarShippers(shippersLogic);
                        }
                        else
                        {
                            if (Entidad == "TerritoriesLogic")
                            {
                                MostrarTerritories(territoriesLogic);
                            }
                        }
                        break;
                    case 5:
                        opcion = 5;
                        break;
                }
            } while (opcion != 5);

        }
        void Mensaje(string msj)
        {
            Console.WriteLine($"{msj} correctamente, presione una tecla para continuar");
            Console.ReadKey();
        }

        void MostrarTerritories(TerritoriesLogic territoriesLogic)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("{0,5} {1,5} {2,40}", "Id", "Descripcion", "Region");
            foreach (Territories territories in territoriesLogic.GetAll())
            {
                Console.WriteLine("{0,5} {1,5} {2,0}", territories.TerritoryID, territories.TerritoryDescription, territories.RegionID);
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        void MostrarShippers(ShippersLogic shippersLogic)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("{0,5} {1,5} {2,20}", "Id", "Compañia", "Telefono");
            foreach (Shippers shippers in shippersLogic.GetAll())
            {
                Console.WriteLine("{0,5} {1,5} {2,20}", shippers.ShipperID, shippers.CompanyName, shippers.Phone);
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
