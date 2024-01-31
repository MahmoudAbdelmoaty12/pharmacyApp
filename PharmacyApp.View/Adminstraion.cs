using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public UI__ViewUser uI { get; set; }
        public AddUser1 AddUserUI { get; set; }
        public UpdateUser UpdateUserUI { get; set; }
        private int WhichUi { get; set; }



        //UI__ViewUser uI = new UI__ViewUser(Users.ToHashSet());
        // Registration registration //new Registration(new ApplicationUserService(new ApplicationUserRepository(new AppDbContext())));
        //UI__ViewUser uI;
        public Adminstraion(Registration registration)
        {
            InitializeComponent();
            _applicationUserService = registration._applicationUserService;
            this.Users = _applicationUserService.GetAllUsers().ToHashSet();
            this.uI = new UI__ViewUser(Users);
            this.AddUserUI = new AddUser1();
            this.UpdateUserUI = new UpdateUser();
           // _applicationUserService = applicationUserService;
            //this.registration = registration;
            
            //applicationUserService = new ApplicationUserService(new ApplicationUserService()); 
            //this.Load += Adminstraion_Load;
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
            this.uI.Visible = false;
            this.UpdateUserUI.Visible = false;
            addUser11.Visible = true;
            addUser11.BringToFront();



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Adminstraion_Load(object sender, EventArgs e)
        {
            //var uiviewuser = new UI__ViewUser(Users);
            
            addUser11.Visible = false;
            //viewUser1.Visible = false;
            updateUser1.Visible = false;
            this.uI.Visible = false;
            BtnAdduser.PerformClick();
            guna2Button4.PerformClick();
            viewUser.PerformClick();
            this.uI.Dock = DockStyle.Right;
            this.Controls.Add(this.uI);



            }
            else if(this.WhichUi == 2)
            {
               
                this.UpdateUserUI.Visible = true;
                this.UpdateUserUI.Dock = DockStyle.Right;
                this.Controls.Add(this.UpdateUserUI);
            }



        }
        private void ChildForm_DataSent(object sender, int data)
        {
            
            var DeletedUser =_applicationUserService.GetUser(data);
            _applicationUserService.DeleteUser(DeletedUser);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.AddUserUI.Visible = false;
            this.UpdateUserUI.Visible = false;
            this.WhichUi = 0;
            this.uI.Visible = true;
            this.uI.BringToFront();
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
            this.uI.Visible = false;
            this.AddUserUI.Visible = false;
            this.WhichUi = 2;
            updateUser1.Visible = true;
            updateUser1.BringToFront();

        }
        //private void AddUser_UI_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    // إظهار النموذج الحالي عند إغلاق AddUser_UI
        //    this.Show();
        //}


    }
}
