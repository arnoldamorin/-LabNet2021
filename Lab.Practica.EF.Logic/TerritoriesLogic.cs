using Lab.Practica.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.EF.Logic
{
    public class TerritoriesLogic : BaseLogic, IABMLogic<Territories>
    {
       public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }
        public void Add(Territories newTerritories)
        {
            context.Territories.Add(newTerritories);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            string idt = Convert.ToString(id);
            var territoryAEliminar = context.Territories.First(t => t.TerritoryID == idt);
            context.Territories.Remove(territoryAEliminar);
            context.SaveChanges();
        }
        public void Update(Territories newTerritories)
        {
            var territoryUpdate = context.Territories.First(t => t.TerritoryID == newTerritories.TerritoryID) ;
            territoryUpdate.TerritoryDescription = newTerritories.TerritoryDescription;
            territoryUpdate.RegionID = newTerritories.RegionID;
            context.SaveChanges();
        }
    }
}
