using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Practica.MVC.Models
{
    public class ShippersView
    {
        [Required]
        public int ShipperID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(24)]
        public string Phone { get; set; }
        
        public List<ShippersView> Shippers { get; set; }
    }
}