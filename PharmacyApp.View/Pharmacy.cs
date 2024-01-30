using pharmacyApp.Application.Services;
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
    public partial class Pharmacy : Form
    {
        //private IMedicineService _medicineService;
        //private IApplicationUserService _userService;
        public Pharmacy(Registration registration)
        {
            InitializeComponent();
            //_medicineService = medicineService;
            //_userService = userService;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //Registration re = new Registration(_UserService);
            //re.Show();
            //this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //uI_AddMedicine1.Visible = true;
            //uI_AddMedicine1.BringToFront();
        }

        private void Pharmacy_Load(object sender, EventArgs e)
        {
            //uI_AddMedicine1.Visible = false;
            //uI_ViewMedicine1.Visible = false;
            //uI_Modify1.Visible = false;
            //Btn_addmedicine.PerformClick();
        }

        private void uI_AddMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //uI_ViewMedicine1.Visible = true;
            //uI_ViewMedicine1.BringToFront();
        }

        private void uI_AddMedicine1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //uI_Modify1. Visible = true;
            //uI_Modify1.BringToFront();
        }
    }
}
