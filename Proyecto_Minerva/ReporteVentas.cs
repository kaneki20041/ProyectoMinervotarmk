using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ReporteVentas : Form
    {
        public DateTime fechaInicial { get; set; }
        public DateTime fechaFinal { get; set; }

        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            fechaInicial = new DateTime(2024, 1, 1); 
            fechaFinal = new DateTime(2024, 12, 31); 

            // Validar las fechas antes de cargar el informe
            if (fechaInicial < new DateTime(1753, 1, 1) || fechaFinal > new DateTime(9999, 12, 31))
            {
                MessageBox.Show("Las fechas deben estar entre el 1 de enero de 1753 y el 31 de diciembre de 9999.");
                return;
            }

            // Cargar el informe
            try
            {
                // Convertir las fechas a formato 'yyyy-MM-dd' antes de pasarlas al TableAdapter
                string fechaInicialStr = fechaInicial.ToString("yyyy-MM-dd");
                string fechaFinalStr = fechaFinal.ToString("yyyy-MM-dd");

                this.spConsultaVentaPorRangoFechasTableAdapter.Fill(this.dataSetMostrarFecha.spConsultaVentaPorRangoFechas, fechaInicial, fechaFinal);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al cargar el informe: " + ex.Message);
            }

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = dtpDesde.Value;
            DateTime fechaFinal = dateTimePicker1.Value;

            // Validar las fechas
            if (fechaInicial < new DateTime(1753, 1, 1) || fechaFinal > new DateTime(9999, 12, 31))
            {
                MessageBox.Show("Las fechas deben estar entre el 1 de enero de 1753 y el 31 de diciembre de 9999.");
                return;
            }

            // Cargar el informe
            try
            {
                string fechaInicialStr = fechaInicial.ToString("yyyy-MM-dd");
                string fechaFinalStr = fechaFinal.ToString("yyyy-MM-dd");

                this.spConsultaVentaPorRangoFechasTableAdapter.Fill(this.dataSetMostrarFecha.spConsultaVentaPorRangoFechas, fechaInicial, fechaFinal);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el informe: " + ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
