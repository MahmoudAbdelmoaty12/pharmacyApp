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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp.View.Admin
{
    public partial class AddUser1 : UserControl
    {
        IApplicationUserService _userService;
        public AddUser1()
        {
            InitializeComponent();
            _userService =new ApplicationUserService(new ApplicationUserRepository(new AppDbContext()));
        }


        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            foreach (char digit in phoneNumber)
            {
                if (!char.IsDigit(digit))
                {
                    return false; // If any character is not a digit, the phone number is invalid
                }
            }
            return true; // All characters are digits, so the phone number is valid
        }
        private ApplicationUserType GetUserType(string userType)
        {
            switch (userType?.ToLower())
            {
                case "admin":
                    return ApplicationUserType.admin;
                case "patient":
                    return ApplicationUserType.user;
                default:
                    return ApplicationUserType.user; // Default to user type if not recognized
            }
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
            string? userType = userTypeComboBox.SelectedItem?.ToString();

            if (name.Length > 3 && password.Length > 8 && email.Contains("@") && isAgeValid && age > 21 && IsPhoneNumberValid(phoneNumber) && !string.IsNullOrEmpty(userType))
            {
                ApplicationUser newUser = new ApplicationUser
                {
                    Name = name,
                    Email = email,
                    Password = password,
                    Address = address,
                    Age = age,
                    PhoneNumber = phoneNumber,
                    Type = GetUserType(userType)
                };

                _userService.AddUser(newUser);
                MessageBox.Show("User registered successfully!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //internal void ShowDialog()
            //{

            //}
        }
    }
}
