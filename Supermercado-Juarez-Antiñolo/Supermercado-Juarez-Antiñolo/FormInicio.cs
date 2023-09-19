using System;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace Supermercado_Juarez_Antiñolo
{
    public partial class FormInicio : MetroForm
    {
        public FormInicio()
        {
            InitializeComponent();
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
    }
}
