using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacyApp.Application.Contract;
using pharmacyApp.models.Models;
using PharmacyApp.Context.Context;

namespace PharmacyApp.Infrastructure.Repositories
{
    public class ApplicationUserRepository:Repository<ApplicationUser,int>,IApplicationUser
    {
        protected AppDbContext _context;
        public ApplicationUserRepository(AppDbContext context)
            : base(context)
        {

            _context = context;

        }

    }
}
