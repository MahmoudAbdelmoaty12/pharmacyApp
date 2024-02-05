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
using pharmacyApp.Application.Contract;
using pharmacyApp.Application.Service;
using pharmacyApp.Application.Services;
using pharmacyApp.models.Models;
using PharmacyApp.Context.Context;
using PharmacyApp.Infrastructure.Repositories;

namespace PharmacyApp.View
{
    public partial class OrderMedicin : Form
    {
        IOrderService _orderService = new OrderService(new OrderRepository(new AppDbContext()));
        IMedicineService _medicineService = new MedicineService(new MedicineRepository(new AppDbContext()));
        ApplicationUser applicationUser1;
        public OrderMedicin(ApplicationUser applicationUser)
        {
            InitializeComponent();
            applicationUser1 = applicationUser;
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


            datagridview.AutoGenerateColumns = true;
            datagridview.DataSource = medicines;
            datagridview.Refresh();
        }
        private void LoadMedicineData()
        {
            var medicines = _medicineService.GetAllMedicins().ToList();
            datagridview.AutoGenerateColumns = true;
            datagridview.DataSource = medicines;
            datagridview.Refresh();
        }
        //private void LoadMedicineData()
        //{

        //    IQueryable<Medicincs> medicien = _medicineService.GetAllMedicins();
        //    foreach (var medic in medicien)
        //    {
        //        datagridview.AutoGenerateColumns = true;
        //        datagridview.DataSource = medic.Name+medic.Price+medic.ProducingCompany+medic.ExpirationDate;
        //        datagridview.Refresh();
        //    }

        //    //datagridview.DataSource = medicien;

        //}
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchText.Text.Trim();

            listBox1.Text = searchQuery;
            SearchMedicineData(searchQuery);
        }
        private void AddtoCartbutton_Click(object sender, EventArgs e)
        {
            //int count = 0;
            decimal totalresult = 0;
            Medicincs medicincs = new Medicincs();

            var name = MedicineName.Text;
            var price = decimal.Parse(PricePerText.Text);
            //var qunatity=int.Parse( Numberofunit.Text);
            var total = decimal.Parse(TotalPriceText.Text);



            // Check if DataGridView columns have been created
            if (datagridview.Columns.Count == 0)
            {
                // Define DataGridView columns
                datagridview.Columns.Add("Name", "Name");
                datagridview.Columns.Add("Price", "Price");
                datagridview.Columns.Add("totalprice", "total");
            }
            datagridview.AutoGenerateColumns = true;

            datagridview.Rows.Add(name, price, total);
            //count++;
            //datagridview.Rows.Add("name", name);
            //datagridview.Rows.Add("price", price);
            //datagridview.Rows.Add("total", total);
            datagridview.Refresh();

            //for(int i= 0;i<datagridview.RowCount;i++)
            //{


            //}


            // ///totalresult  total;



            // //label9.Text =total.ToString();
            // if (int.TryParse(label9.Text, out int total1))
            // {
            //     totalresult += total;
            //     label9.Text += totalresult;
            // }
            // else
            // {
            //     label9.Text = total.ToString();
            // }
            //// this.Refresh();
            // //count++;
            if (decimal.TryParse(label9.Text, out decimal currentTotal))
            {
                totalresult = currentTotal + total;
            }
            else
            {
                totalresult = total;
            }

            // Update the total label
            label9.Text = totalresult.ToString();


        }
        private void listbox()
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedItemText = listBox1.SelectedItem.ToString();
                // Parse the ID from the selected item text
                var medicineId = selectedItemText.Split(':').Last().Trim();

                if (int.TryParse(medicineId, out var id))
                {
                    var medicine = _medicineService.GetMedicine(id);
                    if (medicine != null)
                    {
                        MedicineName.Text = medicine.Name;
                        PricePerText.Text = medicine.Price.ToString();

                    }
                }
            }
        }

        private void MedicineName_TextChanged(object sender, EventArgs e)
        {
            //var medicin = int.Parse(OrderIDText.Text);
            //var medicinname = _medicineService.GetMedicine(medicin);

            //var medicinprice = medicinname.Price;
            //PricePerText.Text = medicinprice.ToString();
            //MedicineName.Text = medicinname.Name.ToString();
            //var quntaty = int.Parse(Numberofunit.Text);
            //var res = medicinprice * quntaty;
            //TotalPriceText.Text = res.ToString();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            //LoadMedicineData();
            //var medicien = _medicineService.GetAllMedicins().ToHashSet().ToString();

            //Datagradview.AutoGenerateColumns = true;
            //Datagradview.DataSource = medicien;
            //Datagradview.Refresh();
        }

        private void Datagradview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderMedicin_Load(object sender, EventArgs e)
        {
            //LoadMedicineData();
            getmedicinlistbox();

        }
        private void getmedicinlistbox()
        {
            var medicines = _medicineService.GetAllMedicins().ToList();
            foreach (var item in medicines)
            {

                listBox1.Items.Add(item.Name);




            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            var medicines1 = _medicineService.GetAllMedicins().ToList();
            foreach (var item in medicines1)
            {
                if (listBox1.SelectedItem == item.Name)
                {
                    var idmedicin = item.Id;

                    var selectedMedicine = _medicineService.GetMedicine(idmedicin);
                    if (selectedMedicine != null)
                    {
                        MedicineName.Text = selectedMedicine.Name;
                        PricePerText.Text = selectedMedicine.Price.ToString();

                        if (!string.IsNullOrWhiteSpace(Numberofunit.Text))
                        {
                            // Parse the quantity and calculate the total price
                            if (int.TryParse(Numberofunit.Text, out int quantity))
                            {
                                var totalPrice = selectedMedicine.Price * quantity;
                                TotalPriceText.Text = totalPrice.ToString();
                            }
                            else
                            {
                                // Handle invalid input for quantity
                                TotalPriceText.Text = "Invalid quantity";
                            }
                        }
                        else
                        {
                            // If the number of units is not provided, default to 1
                            var totalPrice = selectedMedicine.Price * 1;
                            TotalPriceText.Text = totalPrice.ToString();
                        }
                    }

                }

            }

            //listbox();

        }

        private void Numberofunit_TextChanged(object sender, EventArgs e)
        {


            //var x = int.Parse(Numberofunit.Text);

            if (int.TryParse(Numberofunit.Text, out int quantity))
            {
                listBox1_SelectedIndexChanged(quantity, e);
            }
            else
            {
                Numberofunit.Text = " ";
            }

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (datagridview.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = datagridview.SelectedRows[0];

                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this medicine?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Remove the selected row
                    datagridview.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
          //  Order order = new Order();
           // order.Phone = applicationUser1.PhoneNumber;
           // order.AddressUser = applicationUser1.Address;


           // order.date = DateTime.Now;

           // _orderService.AddOrder(order);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
