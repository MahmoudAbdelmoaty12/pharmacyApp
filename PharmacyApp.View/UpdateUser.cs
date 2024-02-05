using pharmacyApp.Application.Services;
using pharmacyApp.models.Models;
using PharmacyApp.Context.Context;
using PharmacyApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp.View
{
    public partial class UpdateUser : UserControl
    {
        IApplicationUserService _userService;
        public UpdateUser()
        {
            InitializeComponent();
            _userService = new ApplicationUserService(new ApplicationUserRepository(new AppDbContext()));
        }
        private ApplicationUserType GetUserType(string userType)
        {
            switch (userType?.ToLower())
            {
                case "admin":
                    return ApplicationUserType.admin;
                case "user":
                    return ApplicationUserType.user;
                default:
                    return ApplicationUserType.user; // Default to user type if not recognized
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int ID =int.Parse(IDtxt.Text);
            string Name = Nametxt.Text;
            int Age = int.Parse(Agetxt.Text);
            string Email = Emailtxt.Text;
            string Password = Passwordtxt.Text;
            string Phone = Phonetxt.Text;
            string Address = Addresstxt.Text;
            string? userType = guna2ComboBox1.SelectedItem?.ToString();
            ApplicationUser IsID = _userService.GetUser(ID) ;
            if (IsID!=null)
            {
                ApplicationUser UpdateUser = new ApplicationUser
                {
                    Id=ID,
                    Name = Name,
                    Email = Email,
                    Password = Password,
                    Address = Address,
                    Age = Age,
                    PhoneNumber = Phone,
                    Type = GetUserType(userType)
                };
                _userService.UpdateUser(UpdateUser);
                MessageBox.Show("User Updated successfully!","Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This User is not Found ");
            }
        }

    }
}
