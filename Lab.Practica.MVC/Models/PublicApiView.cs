using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Practica.MVC.Models
{
    public class PublicApiView
    {
       
            [Required]
            public DateTime Fecha { get; set; }
            [Required]
            public double Venta { get; set; }
            [Required]
            public double Compra { get; set; }
        
     
    }
}