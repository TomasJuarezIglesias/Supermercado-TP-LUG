using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Bunifu;


namespace Supermercado_Juarez_Antiñolo
{
    public partial class FormInicio : MetroForm
    {
        public FormInicio()
        {
            InitializeComponent();
            this.Style = MetroFramework.MetroColorStyle.Black;
        }

        private void btnCRUDprod_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto();
            frm.Show();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FormCategorias frm = new FormCategorias();
            frm.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            FormMedios_de_Pago frm = new FormMedios_de_Pago();
            frm.Show();
        }
    }
}
