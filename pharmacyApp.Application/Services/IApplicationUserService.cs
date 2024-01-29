using pharmacyApp.models.Models;
using System.Linq.Expressions;

namespace pharmacyApp.Application.Services
{
    public interface IApplicationUserService
    {
        ApplicationUser AddUser(ApplicationUser user);
        void DeleteUser(ApplicationUser user);
        IQueryable<ApplicationUser> GetAllUsers();
        IQueryable<ApplicationUser> FindAllUsers(Expression<Func<Medicincs, bool>> criteria, int? take, int? skip, Expression<Func<Medicincs, object>> orderBy = null, string orderByDirection = "ASC");
        ApplicationUser GetUser(int id);
        ApplicationUser GetUserName(string name);
        ApplicationUser GetUserByEmail(string email);
        ApplicationUser UpdateUser(ApplicationUser user);
    }
}