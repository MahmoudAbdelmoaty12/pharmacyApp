using pharmacyApp.Application.Services;
using pharmacyApp.models.Models;
using System.Xml.Linq;

namespace PharmacyApp.View
{
    public partial class Form1 : Form
    {
        private  IApplicationUserService _userService;
        private IMedicineService _medicineService;
        public Form1(IApplicationUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            PasswordTxt.PasswordChar = '*';

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}
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

            if (name.Length > 5 && password.Length > 8 && email.Contains("@") && isAgeValid && age > 21 && IsPhoneNumberValid(phoneNumber)&&!string.IsNullOrEmpty(userType))
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

            UI_AddMedicine uI_Add = new UI_AddMedicine(_medicineService);
            uI_Add.Show();
            
        }
    }
}
