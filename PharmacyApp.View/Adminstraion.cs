using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using pharmacyApp.Application.Services;
using pharmacyApp.models.Models;
using PharmacyApp.Context.Context;
using PharmacyApp.Infrastructure.Repositories;
using PharmacyApp.View.Admin;

namespace PharmacyApp.View
{
    public partial class Adminstraion : Form
    {

        private IApplicationUserService _applicationUserService;
        private HashSet<ApplicationUser> Users { get; set; }
       

        private int WhichUi { get; set; }



     
        public Adminstraion(Registration registration)
        {
            InitializeComponent();
            _applicationUserService = registration._applicationUserService;
            this.Users = _applicationUserService.GetAllUsers().ToHashSet();
          
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //if (_applicationUserService != null)
            //{
            //    Registration re = new Registration(_applicationUserService);
            //    re.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    // Handle the case where applicationUserService is null
            //    MessageBox.Show("Application user service is not initialized.");
            //}

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAdduser_Click(object sender, EventArgs e)
        {
           
            addUser11.Visible = true;
            addUser11.BringToFront();

    

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Adminstraion_Load(object sender, EventArgs e)
        {
          
            addUser11.Visible = false;
            uI__ViewUser1.Visible = false;
            updateUser1.Visible = false;
           
            BtnAdduser.PerformClick();

        }
        private void ChildForm_DataSent(object sender, int data)
        {
            
            var DeletedUser = _applicationUserService.GetUser(data);
            _applicationUserService.DeleteUser(DeletedUser);


           
        }
        private void ChildForm_ApplicationUserSent(object sender, ApplicationUser data)
        {
            // Handle the data received from the child form
            MessageBox.Show($"Data received from child form: {data.Email}");
            //var DeletedUser = _applicationUserService.GetUser(data);
            //_applicationUserService.DeleteUser(DeletedUser);


            // Optionally, you can perform further processing with the data
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uI__ViewUser1.Visible = true;
            uI__ViewUser1.BringToFront();
     
        }
        private void addUser11_Load(object sender, EventArgs e)
        {

        }

        private void addUser11_Load_1(object sender, EventArgs e)
        {

        }

        private void viewUser1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
          
            updateUser1.Visible = true;
            updateUser1.BringToFront();
           

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Pharmacy pharmacy = new Pharmacy();
            pharmacy.Show();
            this.Hide();
        }
    }
}
