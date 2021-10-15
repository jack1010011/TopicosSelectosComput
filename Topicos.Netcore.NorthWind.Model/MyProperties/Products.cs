using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Netcore.NorthWind.Model.Models
{
    public partial class Product
    {
        [NotMapped]
        public string ProviderName { get; set; }
        [NotMapped]
        public string CategoryName { get; set; }
        [NotMapped]
        public string StockUnits { get; set; }

    }    
}
