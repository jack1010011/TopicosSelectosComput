using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Netcore.NorthWind.Model.Models
{
    public partial class OrderDetail
    {
        [NotMapped]
        public int LineaFullAmountBruto { get; set; }
        [NotMapped]
        public int DiscountAmount { get; set; }
        [NotMapped]
        public int Porcentage { get; set; }
        [NotMapped]
        public int LineaFullAmountNeto { get; set; }
    }
}
