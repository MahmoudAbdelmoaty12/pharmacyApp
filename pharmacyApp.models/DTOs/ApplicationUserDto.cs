﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.models.DTOs
{
    internal class ApplicationUserDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
    }
}
