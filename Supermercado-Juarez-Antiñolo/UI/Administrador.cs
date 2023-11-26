using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Administrador : Form
    {
        public Administrador(EntityLoginUser user)
        {
            InitializeComponent();
            businessVenta = new BusinessVenta();
            MostrarMetricas();
            lblSaludo.Text = $"{user.Nombre} {user.Apellido}!";
        }

        BusinessVenta businessVenta;

        private void MostrarMetricas()
        {
            MetricaUltimaSemana metricaUltimaSemana = businessVenta.ObtenerMetricas();
            lblTotalRecaudado.Text += $"${metricaUltimaSemana.TotalRecaudado.ToString("N2")}";
            lblCantidadVentas.Text += metricaUltimaSemana.CantidadProducto.ToString(); 
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto();
            frm.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormDetalles frm = new FormDetalles();
            frm.Show();
            this.Hide();
        }

        private void btnGenerarXML_Click(object sender, EventArgs e)
        {
            businessVenta.GenerarMetricasXML();
        }
    }
}
