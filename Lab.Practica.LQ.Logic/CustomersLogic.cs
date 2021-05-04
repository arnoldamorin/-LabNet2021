using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Practica.LQ.Data;
using Lab.Practica.LQ.Entities;

namespace Lab.Practica.LQ.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        public void JoinCustomersOrder()
        {
            var startDate = new DateTime(1997, 1, 1);
            var query = (from customers in context.Customers
                         join order in context.Orders
                         on customers.CustomerID equals order.CustomerID
                         where customers.Region == "WA" && order.OrderDate > startDate
                         select new
                         {
                             customers.CompanyName,
                             order.OrderID,
                             order.OrderDate
                         });
            foreach (var item in query)
            {
                Console.WriteLine(item.CompanyName, item.OrderID, item.OrderDate);
            }
            // Pd: No encontre manera de devolverlo al program como una nueva tabla, intente creando una nueva "entidad" llamada CustomersOrders y devolver ese tipo
            //de entidad pero no lo pude hacer andar.
            Console.ReadKey();
        }
        public List<Customers> DevolverObjetoCustomers()
        {
            return GetAll();
        }
        public List<Customers>CustomersWashington()
        {
            var query = context.Customers.ToList().Where(p => p.Region == "WA").ToList();
            return query;
        }
        public List<Customers> CustomersWashington3()
        {
            var query = context.Customers.Where(p => p.Region == "WA").Take(3).ToList();
            return query;
        }

        public void NombresMayMin()
        {
           var query = (from Customers in context.Customers
                        select new
                        {
                            NomMay = Customers.CompanyName.ToUpper(),
                            NomMin = Customers.CompanyName.ToLower()
                        });
            foreach (var item in query)
            {
                Console.WriteLine(item.NomMay,item.NomMin);
            }
            Console.ReadKey();
        }    

        public void TresPrimeros()
        {

        }
    }
}
