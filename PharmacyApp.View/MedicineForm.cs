using pharmacyApp.Application.Services;
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
    public partial class MedicineForm : Form
    {
        public MedicineForm()
        {
            InitializeComponent();

            // Subscribe to the Load event of the form
            this.Load += MedicineForm_Load;
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            // Create an instance of UI_AddMedicine
            //var uiviewuser = new UI__ViewUser(new ApplicationUserService(new ApplicationUserRepository(new AppDbContext())));
            var uiAddMedicine = new UI_AddMedicine(new MedicineService(new MedicineRepository(new AppDbContext())));
            var iuviewmedicine= new UI_ViewMedicine(new MedicineService(new MedicineRepository(new AppDbContext())));
            var uimodify = new UI_Modify(new MedicineService(new MedicineRepository(new AppDbContext())));
            // Set the properties of uiAddMedicine as needed
            uiAddMedicine.Dock = DockStyle.Fill;
            iuviewmedicine.Dock = DockStyle.Fill;
            uimodify.Dock = DockStyle.Fill;
            //uiviewuser.Dock = DockStyle.Fill;

            // Add uiAddMedicine to the controls of MedicineForm
            //this.Controls.Add(uiviewuser);
        }
    }
}
