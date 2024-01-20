using pharmacyApp.models.Models;

namespace pharmacyApp.Application.Services
{
    public interface IApplicationUserService
    {
        ApplicationUser AddUser(ApplicationUser user);
        void DeleteUser(ApplicationUser user);
        IQueryable<ApplicationUser> GetAllUsers();
        ApplicationUser GetUser(int id);
        ApplicationUser GetUserName(string name);
        ApplicationUser UpdateUser(ApplicationUser user);
    }
}