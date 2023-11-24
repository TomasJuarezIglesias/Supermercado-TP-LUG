using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto();
            frm.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            btnGestion1.Visible = true;
            btnGestion2.Visible = true;
            btnGestion3.Visible = true;
            btnAdmin.Visible = false;
            btnComprar.Visible = false;
            btnSalir.Visible = true;
            btnMetodosPago.Visible = true;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormComprar frm = new FormComprar();
            frm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnGestion1.Visible = false;
            btnGestion2.Visible = false;
            btnGestion3.Visible = false;
            btnMetodosPago.Visible = false;
            btnAdmin.Visible = true;
            btnComprar.Visible = true;
            btnSalir.Visible = false;
        }

        private void btnGestion3_Click(object sender, EventArgs e)
        {
            FormDetalles frm = new FormDetalles();
            frm.Show();
            this.Hide();
        }

        private void btnMetodosPago_Click(object sender, EventArgs e)
        {
            FormMedioPago frm = new FormMedioPago();
            frm.Show();
            this.Hide();
        }
    }
}
