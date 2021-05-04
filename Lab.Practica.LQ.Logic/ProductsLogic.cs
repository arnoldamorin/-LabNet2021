using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Practica.LQ.Data;
using Lab.Practica.LQ.Entities;

namespace Lab.Practica.LQ.Logic
{
    public class ProductsLogic:BaseLogic
    {

        
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public List<Products> ProductosSinStock()
        {
            var query = context.Products.Where(p => p.UnitsInStock == 0).ToList();
            return query;
        }

        public List<Products> Producto789()
        {
            var query = context.Products.FirstOrDefault(p => p.ProductID == 789);
            List<Products> result = new List<Products>();
            result.Add(query);
            return result;
        }
        public List<Products> StockMasde3Pesos()
        {
            var query = context.Products.ToList().Where(p => p.UnitPrice > 3 && p.UnitsInStock > 0).ToList();            
            return query;
        }        
        public List<Products> NombresOrdenados()
        {
            var query = (from Products in Products
                         where
        } 
       
     
    }
}
