using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace PharmacyApp.View
{
    public partial class UI__ViewUser : UserControl
    {
        HashSet<ApplicationUser> _Users;
        public event EventHandler<int> UserIdSent;
        IApplicationUserService _UserService;
        public UI__ViewUser(HashSet<ApplicationUser> Users)
        {
            InitializeComponent();
            _Users = Users;
            _UserService = new ApplicationUserService(new ApplicationUserRepository(new AppDbContext()));
        }
        //public delegate void DataChangedEventHandler(object sender, DataChangedEventArgs e);
        //public event DataChangedEventHandler OnDataChanged;

        //public void RaiseDataChangedEvent(string textValue, int numberValue)
        //{
        //    OnDataChanged?.Invoke(this, new DataChangedEventArgs(textValue, numberValue));
        //}
        private void LoadUserData()
        {
            // var Users = _Users.ToList();

           var users= _UserService.GetAllUsers().ToList();
            guna2DataGridView1.AutoGenerateColumns = true;
            guna2DataGridView1.DataSource = users;
            guna2DataGridView1.Refresh();
        }

        private void SearchUserData(string searchQuery)
        {
            var Users = _Users.Where(user => user.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
            guna2DataGridView1.AutoGenerateColumns = true;
            guna2DataGridView1.DataSource = Users;
            guna2DataGridView1.Refresh();
        }

        private void UI__ViewUser_Load(object sender, EventArgs e)
        {
            LoadUserData();
            guna2DataGridView1.Refresh();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SearchUserData(guna2TextBox1.Text);
        }
        public void ChildForm_UserIdSent(object sender, int value)
        {
            // Handle the received value here
            MessageBox.Show("Received value: " + value);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this medicine?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    var selectedUser = guna2DataGridView1.SelectedRows[0];
                    var UserId = (int)selectedUser.Cells[0].Value;
                    //ApplicationUser user = new()
                    //{
                    //    selectedUser.Cells[0].Value,
                    //}
                    //_Users.Remove(selectedUser);


                    if (UserIdSent != null)
                    {
                        UserIdSent.Invoke(this, UserId);
                    }

                    LoadUserData();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}