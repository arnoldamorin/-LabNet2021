using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrudAPi.Models
{
    [MetadataType(typeof(Shippers.MetaData))]
    public partial class Shippers
    {
       sealed class MetaData
        {          
            [Required] 
            public string CompanyName;
            [Required]
            public string Phone;
        }
    }
}