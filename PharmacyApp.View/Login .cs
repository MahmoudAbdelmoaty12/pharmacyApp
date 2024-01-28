using pharmacyApp.Application.Services;
using pharmacyApp.models.Models;
using PharmacyApp.View.registerUser;
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
    public partial class Registration : Form
    {
        public IApplicationUserService _applicationUserService;
        public Registration(IApplicationUserService applicationUserService)
        {
            InitializeComponent();
            _applicationUserService = applicationUserService;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btnreset_Click(object sender, EventArgs e)
        {
            TextUsername.Clear();
            TextPassword.Clear();
        }

        private void Btnsignin_Click(object sender, EventArgs e)
        {
            ApplicationUser res = _applicationUserService.GetUserByEmail(TextUsername.Text);
            if (res != null)
            {
                if (res.Password == TextPassword.Text)
                {
                    Adminstraion f = new Adminstraion();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Login Please Enter right Email and Password");
                }
            }
            else
            {
                MessageBox.Show("wrong username or passowrd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RegisterUser register_User = new RegisterUser(_applicationUserService);
            register_User.Show();
            this.Hide();
        }
    }
}
