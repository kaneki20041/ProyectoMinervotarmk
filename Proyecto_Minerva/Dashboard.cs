using CapaPresentacion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace CapaPresentacion
{
    public partial class Dashboard : Form
    {

        //filas
        private DashBoard model;

        public Dashboard()
        {
            InitializeComponent();

            //Predeterminado - Ultimos 7 Dias
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            model = new DashBoard();
            LoadData();

        }

        //Metodos Privados
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lblNumOrders.Text = model.numOrders.ToString();
                lblTotalRevenue.Text = "S/" + model.TotalRevenue.ToString();
                lblTotalProfit.Text = "S/" + model.TotalProfit.ToString();

                lblNumCustomers.Text = model.NumeroClientes.ToString();
                lblNumProducts.Text = model.NumeroProveedores.ToString();
                lblNumSuppliers.Text = model.NumeroPrenda.ToString();

                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Fecha";
                chartGrossRevenue.Series[0].YValueMembers = "CantidadTotal";
                chartGrossRevenue.DataBind();

                chartTopProducts.DataSource = model.TopPrendasList;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();

                dgvUnderstock.DataSource = model.UnderstockList;
                dgvUnderstock.Columns[0].HeaderText = "Item";
                dgvUnderstock.Columns[1].HeaderText = "Units";
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void DisableCustomDates()
        {
            groupBox1.Enabled = false;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month,1);
            dtpEndDate.Value = DateTime.Now;

            LoadData();
            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;

            LoadData();
            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;

            LoadData();
            DisableCustomDates();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;

            LoadData();
            DisableCustomDates();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
