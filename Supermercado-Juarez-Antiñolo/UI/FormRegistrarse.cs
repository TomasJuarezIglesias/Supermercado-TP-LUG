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
using Business;
using Entity;

namespace UI
{
    public partial class FormRegistrarse : ServiceForm
    {
        public FormRegistrarse()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            BusinessCliente gestor = new BusinessCliente();
            EntityCliente cliente = new EntityCliente();
            try
            {
                cliente.Dni = int.Parse(txtDni.Text);
                cliente.Telefono = int.Parse(txtTelefono.Text);
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                this.RevisarRespuestaServicio(gestor.Agregar(cliente));
            }
            catch
            {
                MessageBox.Show("Formato incorrecto en DNI o telefono");
                return;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FormComprar frm = new FormComprar();
            frm.Show();
            this.Hide();
        }
    }
}
