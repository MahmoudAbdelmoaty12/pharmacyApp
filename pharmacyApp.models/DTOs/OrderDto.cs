using pharmacyApp.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.models.DTOs
{
    internal class OrderDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string MedicinceName { get; set; }
        public DateTime date { get; set; }
        public string? AddressUser { get; set; }
        public string? Phone { get; set; }
        public string Status { get; set; }
    }
}
