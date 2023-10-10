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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
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
            btnAdmin.Visible = false;
            btnComprar.Visible = false;
            btnSalir.Visible = true;
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
            btnAdmin.Visible = true;
            btnComprar.Visible = true;
            btnSalir.Visible = false;
        }
    }
}
