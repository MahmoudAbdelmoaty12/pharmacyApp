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
using pharmacyApp.Application.Service;
using pharmacyApp.Application.Services;
using pharmacyApp.models.Models;
using PharmacyApp.Context.Context;
using PharmacyApp.Infrastructure.Repositories;

namespace PharmacyApp.View
{
    public partial class OrderMedicine : UserControl
    {
        

        IOrderService _orderService =  new OrderService(new OrderRepository(new AppDbContext()));
        IMedicineService _medicineService = new MedicineService(new MedicineRepository(new AppDbContext()));
        public OrderMedicine()
        {
            InitializeComponent();
            

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


            Datagradview.AutoGenerateColumns = true;
            Datagradview.DataSource = medicines;
            Datagradview.Refresh();
        }

        private void LoadMedicineData()
        {
            var medicien = _medicineService.GetAllMedicins().ToHashSet();

            Datagradview.AutoGenerateColumns = true;
            Datagradview.DataSource = medicien;
            Datagradview.Refresh();
        }
        //private MedicincsType GetMedicineType(string? medicinetype)
        //{
        //    switch (medicinetype)
        //    {
        //        case "Rivet":
        //            return MedicincsType.Rivet;
        //        case "Syrup":
        //            return MedicincsType.Syrup;
        //        case "Injection":
        //            return MedicincsType.Injection;
        //        case "Suppositories":
        //            return MedicincsType.Suppositories;
        //        default:
        //            return MedicincsType.Rivet; // Default to user type if not recognized
        //    }
        //}
        private void OrderMedicine_Load(object sender, EventArgs e)
        {

           
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchText.Text.Trim();

            listBox1.Text = searchQuery;
            SearchMedicineData(searchQuery);
        }

        private void AddtoCartbutton_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(OrderIDText.Text);
            string name = MedicineName.Text;
            int numberofunit = int.Parse(Numberofunit.Text);
            Order order = new Order()
            {
                Id = orderId,

            };
            var namemedicin = _medicineService.GetMedicineName(name);

        }

        private void MedicineName_TextChanged(object sender, EventArgs e)
        {
            var medicin = MedicineName.Text;
            var medicinname = _medicineService.GetMedicineName(medicin);
            var medicinprice = medicinname.Price.ToString();
                 PricePerText.Text=medicinprice.ToString();
            var quntaty = Numberofunit.Text;
            var res = decimal.Parse( medicinprice) *decimal.Parse( quntaty);
            TotalPriceText.Text = res.ToString();

        }

        private void Numberofunit_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void TotalPriceText_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
