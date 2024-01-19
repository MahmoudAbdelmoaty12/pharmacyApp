using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.models.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ApplicationUser? User { get; set; }
        public Medicincs? medicince { get; set; } 
        public DateTime date { get; set; }
        public string? AddressUser { get; set; }
        public string? Phone { get; set; }
    }
}
