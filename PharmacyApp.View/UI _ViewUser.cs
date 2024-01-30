using Guna.UI2.WinForms;
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
    public partial class UI__ViewUser : UserControl
    {
        List<ApplicationUser> _Users;
        public UI__ViewUser(List<ApplicationUser> Users)
        {
            InitializeComponent();
            _Users = Users;
        }
        //public delegate void DataChangedEventHandler(object sender, DataChangedEventArgs e);
        //public event DataChangedEventHandler OnDataChanged;

        //public void RaiseDataChangedEvent(string textValue, int numberValue)
        //{
        //    OnDataChanged?.Invoke(this, new DataChangedEventArgs(textValue, numberValue));
        //}
        private void LoadUserData()
        {
            //var Users = _applicationUserService.GetAllUsers()?.ToHashSet();


            guna2DataGridView1.AutoGenerateColumns = true;
            guna2DataGridView1.DataSource = _Users;
            guna2DataGridView1.Refresh();
        }

        private void SearchUserData(string searchQuery)
        {
            /*var Users = _applicationUserService.FindAllUsers(
                user => user.Name.Contains(searchQuery),
                take: null,
                skip: null,
                orderBy: null,
                orderByDirection: "ASC"
            ).ToList();


            guna2DataGridView1.AutoGenerateColumns = true;
            guna2DataGridView1.DataSource = Users;
            guna2DataGridView1.Refresh();*/
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
    }
}