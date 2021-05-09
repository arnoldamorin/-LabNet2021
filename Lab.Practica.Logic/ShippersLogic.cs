using Lab.Practica.Data;
using Lab.Practica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }
        public void Add(Shippers newShippers)
        {
            context.Shippers.Add(newShippers);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ShippersAEliminar = context.Shippers.Find(id);
            context.Shippers.Remove(ShippersAEliminar);
            context.SaveChanges();
        }
        public void Update(Shippers uShippers)
        {
            var updateShippers = context.Shippers.Find(uShippers.ShipperID);
            updateShippers.CompanyName = uShippers.CompanyName;
            updateShippers.Phone = uShippers.Phone;
            context.SaveChanges();
        }
        public Shippers GetOne(int id)
        {
            return context.Shippers.Find(id);
        }
    }
}
