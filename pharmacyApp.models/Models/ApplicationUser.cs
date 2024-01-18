using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.models.Models

  


{
    public enum ApplicationUserType
    {
        user = 0,
        admin =1,
    }
    public class ApplicationUser
    {
        public int  Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
        public ApplicationUserType Type { get; set; }
        
        public HashSet<Order>? orders { get; set; }
    }
}
