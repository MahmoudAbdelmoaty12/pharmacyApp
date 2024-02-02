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
    public partial class UI_ViewMedicine : UserControl
    {
        private IMedicineService _medicineService;
        public UI_ViewMedicine( )
        {
            InitializeComponent();
            _medicineService = new MedicineService(new MedicineRepository(new AppDbContext())); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadMedicineData()
        {
            var medicines = _medicineService.GetAllMedicins().ToHashSet();


            guna2DataGridView1.AutoGenerateColumns = true;
            guna2DataGridView1.DataSource = medicines;
            guna2DataGridView1.Refresh();
        }

        private void SearchMedicineData(string searchQuery)
        {
            var medicines = _medicineService.FindAllMedicins(
                m => m.Name.Contains(searchQuery),
                take: null,
                skip: null,
                orderBy: null,
                orderByDirection: "ASC"
            ).ToList();


            guna2DataGridView1.AutoGenerateColumns = true;
            guna2DataGridView1.DataSource = medicines;
            guna2DataGridView1.Refresh();
        }

        private void UI_ViewMedicine_Load(object sender, EventArgs e)
        {
            LoadMedicineData();
            guna2DataGridView1.Refresh();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string searchQuery = guna2TextBox1.Text.Trim();


            SearchMedicineData(searchQuery);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                
                Medicincs selectedMedicine = (Medicincs)guna2DataGridView1.SelectedRows[0].DataBoundItem;

                
                DialogResult result = MessageBox.Show("Are you sure you want to delete this medicine?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    
                    _medicineService.DeleteMedicine(selectedMedicine);

                   
                    LoadMedicineData();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
