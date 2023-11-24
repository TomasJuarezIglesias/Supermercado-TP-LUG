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

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormComprar frm = new FormComprar();
            frm.Show();
            this.Hide();
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
