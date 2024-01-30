using pharmacyApp.Application.Contract;
using pharmacyApp.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pharmacyApp.Application.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        IApplicationUser _applicationUser;

        public ApplicationUserService(IApplicationUser applicationUser)
        {
            _applicationUser = applicationUser;
        }
        public ApplicationUser AddUser(ApplicationUser user)
        {
            var add = _applicationUser.Add(user);
            _applicationUser.Save();
            return add;
        }
        public ApplicationUser GetUser(int id)
        {
            return _applicationUser.GetById(id);
        }
        public IQueryable<ApplicationUser> GetAllUsers()
        {
            return _applicationUser.GetAll();
        }

        public void DeleteUser(ApplicationUser user)
        {
            _applicationUser.Delete(user);
            _applicationUser.Save();
        }

        public ApplicationUser UpdateUser(ApplicationUser user)
        {

            var delete = _applicationUser.Update(user);
            _applicationUser.Save();
            return delete;
        }
        public ApplicationUser GetUserName(string name)
        {
            return _applicationUser.GetByName(name);
        }

        public ApplicationUser GetUserByEmail(string email)
        {
            return (_applicationUser.FindAll(User => User.Email == email.ToLower(), 1, 0).SingleOrDefault());
        }
        public IQueryable<ApplicationUser> FindAllUsers(Expression<Func<ApplicationUser, bool>> criteria, int? take, int? skip, Expression<Func<ApplicationUser, object>> orderBy = null, string orderByDirection = "ASC")
        {
            return _applicationUser.FindAll(user => user.Name.Contains(orderByDirection, StringComparison.CurrentCultureIgnoreCase),10,0);
        }
    }
}
