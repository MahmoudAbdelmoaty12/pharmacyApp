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
using PharmacyApp.View.Admin;

namespace PharmacyApp.View
{
    public partial class Adminstraion : Form
    {
        public Adminstraion()
        {
            InitializeComponent();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {


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
            viewUser1.Visible = false;
            BtnAdduser.PerformClick();



        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            viewUser1.Visible = true;
            viewUser1.BringToFront();
        }

        private void addUser11_Load(object sender, EventArgs e)
        {

        }

        private void addUser11_Load_1(object sender, EventArgs e)
        {

        }
        //private void AddUser_UI_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    // إظهار النموذج الحالي عند إغلاق AddUser_UI
        //    this.Show();
        //}


    }
}
