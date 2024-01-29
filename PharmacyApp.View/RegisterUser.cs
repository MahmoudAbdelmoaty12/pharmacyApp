using pharmacyApp.Application.Services;
using pharmacyApp.models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp.View
{
    public partial class RegisterUser : Form
    {
        private IApplicationUserService _userService;
        public RegisterUser(IApplicationUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            PasswordTxt.PasswordChar = '*';

        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            foreach (char digit in phoneNumber)
            {
                if (!char.IsDigit(digit))
                {
                    return false; 
                }
            }
            return true; 
        }
        private ApplicationUserType GetUserType(string userType)
        {
            if (userType.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                return ApplicationUserType.admin;
            }
            else if (userType.Equals("Patient", StringComparison.OrdinalIgnoreCase))
            {
                return ApplicationUserType.user;
            }
            return ApplicationUserType.user; 
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string name = NameTxt.Text;
            string email = EmailTxt.Text;
            string password = PasswordTxt.Text;
            string address = AddressTxt.Text;
            int age;
            bool isAgeValid = int.TryParse(AgeTxt.Text, out age);
            string phoneNumber = PhoneTxt.Text;

            if (name.Length > 3 && password.Length > 8 && email.Contains("@") && isAgeValid && age > 21 && IsPhoneNumberValid(phoneNumber))
            {
                ApplicationUser newUser = new ApplicationUser
                {
                    Name = name,
                    Email = email,
                    Password = password,
                    Address = address,
                    Age = age,
                    PhoneNumber = phoneNumber,
                    Type = GetUserType("Patient")
                };

                _userService.AddUser(newUser);
                MessageBox.Show("User registered successfully!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Assuming "Registration" is the next form to show
                Registration registration = new Registration(_userService);
                registration.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Registration failed. Please check the input values and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            NameTxt.Clear();
            EmailTxt.Clear();
            PhoneTxt.Clear();
            PasswordTxt.Clear();
            AgeTxt.Clear();
            AddressTxt.Clear();
        }
    }
}
