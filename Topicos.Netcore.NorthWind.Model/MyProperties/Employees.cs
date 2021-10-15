using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Netcore.NorthWind.Model.Models
{
    public partial class Employee
    {
        [NotMapped]
        public string JefaturaName { get; set; }
        [NotMapped]
        public string EmployeeFullName {
            get {

                string result = this.TitleOfCourtesy ?? ""; //null-coalescing-operator - concatenate Title

                result += $" {(this.FirstName ?? "")}";
                result += $" {(this.LastName ?? "")}";

                return result; 
            } 
            set { } 
        }
    }
}
