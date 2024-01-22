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
        public Registration()
        {
            InitializeComponent();
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
            if(TextUsername.Text=="mostafa"&& TextPassword.Text=="123")
            {
               // Adminstrator adminstrator = new Adminstrator();
                Adminstraion f = new Adminstraion();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong username or passowrd","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
