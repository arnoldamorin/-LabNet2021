namespace Lab.Practica.LQ.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomersOrders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomersOrders()
        {
           
        }

        public int OrderID { get; set; }      
        public string CompanyName { get; set; }
        public DateTime? OrderDate { get; set; }      


    }
}
