using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cibertec.Models
{
   public class Customer
    {

        //[Id], [FirstName], [LastName], [City], [Country], [Phone]

        public int Id { get; set; }
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [Display(Name = "Ciudad")]
        public string City { get; set; }
        [Display(Name = "País")]
        public string Country { get; set; }
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }
    }
}
