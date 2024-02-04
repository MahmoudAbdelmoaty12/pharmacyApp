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
    public partial class UI_Modify : UserControl
    {
        private IMedicineService _medicineService;

        public UI_Modify()
        {
            InitializeComponent();
            _medicineService = new MedicineService(new MedicineRepository(new AppDbContext()));
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {
                var medicine = _medicineService.GetMedicine(int.Parse(guna2TextBox1.Text));
                if (medicine != null)
                {

                    guna2TextBox2.Text = medicine.Name;
                    guna2TextBox3.Text = medicine.Tapes.ToString();
                    guna2DateTimePicker1.Value = (DateTime)medicine.ExpirationDate;
                    guna2DateTimePicker2.Value = (DateTime)medicine.ProductionDate;
                    guna2TextBox4.Text = medicine.Quantity.ToString();
                    guna2TextBox5.Text = medicine.Price.ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter Right Id");
                }
            }
            else if (guna2TextBox2.Text != "")
            {
                var medicine = _medicineService.GetMedicineName(guna2TextBox2.Text.ToString());
                if (medicine != null)
                {
                    guna2TextBox1.Text = medicine.Id.ToString();
                    guna2TextBox2.Text = medicine.Name;
                    guna2TextBox3.Text = medicine.Tapes.ToString();
                    guna2DateTimePicker1.Value = (DateTime)medicine.ExpirationDate;
                    guna2DateTimePicker2.Value = (DateTime)medicine.ProductionDate;
                    guna2TextBox4.Text = medicine.Quantity.ToString();
                    guna2TextBox5.Text = medicine.Price.ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter Right Name");
                }
            }

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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {
                var medicine = _medicineService.GetMedicine(int.Parse(guna2TextBox1.Text));
                if (medicine != null)
                {

                    guna2TextBox2.Text = medicine.Name;
                    guna2TextBox3.Text = medicine.Tapes.ToString();
                    guna2DateTimePicker1.Value = (DateTime)medicine.ExpirationDate;
                    guna2DateTimePicker2.Value = (DateTime)medicine.ProductionDate;
                    guna2TextBox4.Text = medicine.Quantity.ToString();
                    guna2TextBox5.Text = medicine.Price.ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter Right Id");
                }
            }
            else if (guna2TextBox2.Text != "")
            {
                var medicine = _medicineService.GetMedicineName(guna2TextBox2.Text.ToString());
                if (medicine != null)
                {
                    guna2TextBox1.Text = medicine.Id.ToString();
                    guna2TextBox2.Text = medicine.Name;
                    guna2TextBox3.Text = medicine.Tapes.ToString();
                    guna2DateTimePicker1.Value = (DateTime)medicine.ExpirationDate;
                    guna2DateTimePicker2.Value = (DateTime)medicine.ProductionDate;
                    guna2TextBox4.Text = medicine.Quantity.ToString();
                    guna2TextBox5.Text = medicine.Price.ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter Right Name");
                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(guna2TextBox1.Text);
            string name = guna2TextBox2.Text;
            int tapes = int.Parse(guna2TextBox3.Text);
            DateTime valid = guna2DateTimePicker1.Value;
            DateTime expire = guna2DateTimePicker2.Value;
            int quntity = int.Parse(guna2TextBox4.Text);
            decimal price = decimal.Parse(guna2TextBox5.Text);

            Medicincs medicincs = new Medicincs()
            {
                Id=ID,
                Name = name,
                Tapes = tapes,
                ProductionDate = valid,
                ExpirationDate = expire,
                Quantity = quntity,
                Price = price,
                Type = GetMedicineType("Rivet")
            };

            _medicineService.UpdateMedicine(medicincs);
            MessageBox.Show("Medicine Updated successfully!");

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2TextBox4.Clear();
            guna2TextBox5.Clear();
            guna2TextBox6.Clear();
        }
    }
}

