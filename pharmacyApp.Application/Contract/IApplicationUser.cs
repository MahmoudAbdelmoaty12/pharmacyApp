using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacyApp.models.Models;

namespace pharmacyApp.Application.Contract
{
    public interface IApplicationUser : IRepository<ApplicationUser, int>
    {
        ApplicationUser Add(ApplicationUser user);
        void Delete(ApplicationUser user);
        ApplicationUser Update(ApplicationUser user);
    }
}
