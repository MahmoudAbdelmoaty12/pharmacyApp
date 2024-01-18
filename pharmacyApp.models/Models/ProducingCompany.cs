using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.models.Models
{
    public class ProducingCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public ICollection<Medicincs> Medicincs { get; set; }
    }
}
