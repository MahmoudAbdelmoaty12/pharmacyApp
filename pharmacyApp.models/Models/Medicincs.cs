using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.models.Models
{
    public enum MedicincsType
    {
        Rivet=0,
        Syrup=1,
        Injection=2,
        Suppositories=3
    }
    public class Medicincs
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int NumberOfOrder { get; set; }
        public MedicincsType Type { get; set; }
        public HashSet<Order>? orders { get; set; }
        public ProducingCompany? ProducingCompany { get; set; }


    }
}
