using Lab.Practica.LQ.Entities;
using Lab.Practica.LQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.LQ.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsLogic productsLogic = new ProductsLogic();
            CustomersLogic customersLogic = new CustomersLogic();

            //1.Query para devolver objeto customer
            //MostrarCustomers(customersLogic.DevolverObjetoCustomers());

            //2.Query para devolver todos los productos sin stock

            //MostrarProducts(productsLogic.ProductosSinStock());

            //3.Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad
            //MostrarProducts(productsLogic.StockMasde3Pesos());

            //4.Query para devolver todos los customers de Washington
            //MostrarCustomers(customersLogic.CustomersWashington());

            //5.Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789           

            /*void MostrarProducts(List<Products> products)
            {
                foreach (var item in products)
                {
                    try
                    {
                        Console.WriteLine(item.ProductName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Null "+ex.Message);
                        Console.ReadKey();
                    }
                }
                Console.ReadKey();
            }*/


            //6.Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.
            //customersLogic.NombresMayMin();

            //7.Query para devolver Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1 / 1 / 1997.
            customersLogic.JoinCustomersOrder();

            //Los siguientes ejercicios no son obligatorios, pero es deseable que estén resueltos:
            //8.Query para devolver los primeros 3 Customers de Washington
            MostrarCustomers(customersLogic.CustomersWashington3());

            //9.Query para devolver lista de productos ordenados por nombre

            //10.Query para devolver lista de productos ordenados por unit in stock de mayor a menor.
            //11.Query para devolver las distintas categorías asociadas a los productos
            //12.Query para devolver el primer elemento de una lista de productos
            //13.Query para devolver los customer con la cantidad de ordenes asociadas


            void MostrarProducts(List<Products> products)
            {
                foreach (var item in products)
                {
                    Console.WriteLine(item.ProductName);
                }
                Console.ReadKey();
            }
            void MostrarCustomers(List<Customers> customers)
            {
                foreach (var item in customers)
                {
                    Console.WriteLine(item.CompanyName);
                }
                Console.ReadKey();
            }
            
        }
    }
}
