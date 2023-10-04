using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Business;

namespace UI
{
    public partial class FormCliente : ServiceForm
    {
        public FormCliente()
        {
            InitializeComponent();
            mostrarLista();
        }

        private void mostrarLista()
        {
            DGclienteView.DataSource = null;
            DGclienteView.DataSource = gestor.listar().Data;
        }

        BusinessCliente gestor = new BusinessCliente();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EntityCliente cliente = new EntityCliente();
            try
            {
                cliente.Dni = int.Parse(txtDni.Text);
                cliente.Telefono = int.Parse(txtTelefono.Text);
            }
            catch
            {
                MessageBox.Show("Formato incorrecto en DNI o telefono");
                return;
            }
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            this.RevisarRespuestaServicio(gestor.Agregar(cliente));
            mostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntityCliente cliente = new EntityCliente();
            try
            {
                cliente.Dni = int.Parse(txtDni.Text);
            }
            catch
            {
                MessageBox.Show("Formato incorrecto en DNI o telefono");
                return;
            }
            this.RevisarRespuestaServicio(gestor.Eliminar(cliente));
            mostrarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EntityCliente cliente = new EntityCliente();
            try
            {
                cliente.Dni = int.Parse(txtDni.Text);
                cliente.Telefono = int.Parse(txtTelefono.Text);

            }
            catch
            {
                MessageBox.Show("Formato incorrecto en DNI o telefono");
                return;
            }
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            this.RevisarRespuestaServicio(gestor.Modificar(cliente));
            mostrarLista();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormInicio frm = new FormInicio();
            frm.Show();
            this.Close();
        }
    }
}
