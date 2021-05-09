using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Practica.MVC.Models
{
    public class TerritoriesView
    {
        [Required]
        [StringLength(20)]
        public string TerritoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string TerritoryDescription { get; set; }
        [Required]
     
        public int RegionID { get; set; }
        public List<TerritoriesView> Territories { get; set; }
    }
}