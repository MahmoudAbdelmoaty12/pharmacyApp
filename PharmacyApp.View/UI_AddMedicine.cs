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

    public partial class UI_AddMedicine : UserControl
    {
        private IMedicineService _medicineService;
        public UI_AddMedicine(IMedicineService medicineService)
        {
            InitializeComponent();
            _medicineService = medicineService;
        }

        private void UI_AddMedicine_Load(object sender, EventArgs e)
        {

        }
        private MedicincsType GetMedicineType(string? medicinetype)
        {
            switch (medicinetype)
            {
                case "Rivet":
                    return MedicincsType.Rivet;
                case "Syrup":
                    return MedicincsType.Syrup;
                case "Injection":
                    return MedicincsType.Injection;
                case "Suppositories":
                    return MedicincsType.Suppositories;
                default:
                    return MedicincsType.Rivet; // Default to user type if not recognized
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Text;
            int tapes = int.Parse(tapestxt.Text);
            DateTime valid = guna2DateTimePicker1.Value;
            DateTime expire = guna2DateTimePicker2.Value;
            int quntity = int.Parse(Quantitytxt.Text);
            int price = int.Parse(Pricetxt.Text);
            string? medicinetype = guna2ComboBox1.SelectedItem?.ToString();

            Medicincs medicincs = new Medicincs()
            {
                Name = name,
                Tapes = tapes,
                ProductionDate = valid,
                ExpirationDate = expire,
                Quantity = quntity,
                Price = price,
                Type = GetMedicineType(medicinetype)
            };

            _medicineService.AddMedicine(medicincs);
            MessageBox.Show("Medicine Added successfully!");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Nametxt.Clear();
            tapestxt.Clear();
            Quantitytxt.Clear();
            Pricetxt.Clear();

        }
    }
}
