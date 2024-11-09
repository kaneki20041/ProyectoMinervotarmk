using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class ReporteVenta : Form
    {
        public ReporteVenta()
        {
            InitializeComponent();
        }

        private void ReporteVenta_Load(object sender, EventArgs e)
        {
           

            var dataAdapter = new DataSet1TableAdapters.DataTable1TableAdapter();
            dataSet1.EnforceConstraints = false; // Deshabilitar restricciones temporalmente
            dataAdapter.Fill(this.dataSet1.DataTable1);
            //dataSet1.EnforceConstraints = true; // Habilitar restricciones nuevamente
            dataAdapter.Fill(this.dataSet1.DataTable1);
            this.reportViewer1.RefreshReport();
        }

        private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
