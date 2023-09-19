using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Business;
using Entity;

namespace Supermercado_Juarez_Antiñolo
{
    public partial class FormCliente : MetroForm
    {
        public FormCliente()
        {
            InitializeComponent();
            mostrarLista();
            
        }

        BusinessCliente gestor = new BusinessCliente();
        EntityCliente cliente;

        private void mostrarLista()
        {
            DGclienteView.DataSource = null;
            DGclienteView.DataSource = gestor.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cliente = new EntityCliente();
            cliente.Dni = int.Parse(txtDni.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
           if(!gestor.Agregar(cliente))
            {
                MessageBox.Show("No se pudo agregar");
                return;
            }
            MessageBox.Show("Se agrego correctamnete");
            mostrarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            cliente = new EntityCliente();
            cliente.Dni = int.Parse(txtDni.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            if (!gestor.Modificar(cliente))
            {
                MessageBox.Show("No se pudo modificar");
                return;
            }
            MessageBox.Show("Se modificó correctamente");
            mostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cliente = new EntityCliente();
            cliente.Dni = int.Parse(txtDni.Text);
            if (!gestor.Eliminar(cliente))
            {
                MessageBox.Show("No se pudo eliminar");
                return;
            }
            MessageBox.Show("Se eliminó correctamente");
            mostrarLista();
        }

        private void DGclienteView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = DGclienteView.Rows[e.RowIndex];
            txtDni.Text = selectedRow.Cells["Dni"].Value.ToString();
            txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = selectedRow.Cells["Apellido"].Value.ToString();
            txtTelefono.Text = selectedRow.Cells["Telefono"].Value.ToString();            
        }
    }
}
