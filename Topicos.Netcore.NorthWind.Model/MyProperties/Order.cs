using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Netcore.NorthWind.Model.Models
{
    public partial class Order
    {
        [NotMapped]
        public DateTime? DaysToFabric { get; set; }
    }
}
