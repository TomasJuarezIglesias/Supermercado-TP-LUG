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
using Entity;
using Business;

namespace Supermercado_Juarez_Antiñolo
{
    public partial class FormMedios_de_Pago : MetroForm
    {
        BusinessMedioPago gestor = new BusinessMedioPago();
        public FormMedios_de_Pago()
        {
            InitializeComponent();
            loadTarjetas();
            mostrarLista();
        }

        private void loadTarjetas()
        {
            List<EntityTipoTarjeta> list = gestor.loadTipoTarjeta();
            foreach (var item in list)
            {
                cmbTiposTarjetas.Items.Add(item.Nombre);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDniCliente.Text == "" || txtDniCliente.Text == "" || txtNroTarjeta.Text == "" || cmbTiposTarjetas.Text == "") { MessageBox.Show("Rellene campos"); }
            EntityMedioPago medioPago = new EntityMedioPago();
            medioPago.Id_cliente = int.Parse(txtDniCliente.Text);
            medioPago.Id_Tipo_Tarjeta = gestor.BuscarId(cmbTiposTarjetas.Text);
            medioPago.NroTarjeta = int.Parse(txtNroTarjeta.Text);
            medioPago.FechaCaducidad = txtFecha.Value;
            medioPago.Cvv = int.Parse(txtCvv.Text);
            if(! gestor.agregar(medioPago))
            {
                MessageBox.Show("No se pudo agregar");
                return;
            }
            MessageBox.Show("Se agregó correctamente");
            mostrarLista();
        }

        private void mostrarLista()
        {
            DGmediosView.DataSource = null;
            DGmediosView.DataSource = gestor.listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtDniCliente.Text == "" || txtDniCliente.Text == "" || txtNroTarjeta.Text == "" || cmbTiposTarjetas.Text == "") { MessageBox.Show("Rellene campos"); }
            EntityMedioPago medioPago = new EntityMedioPago();
            medioPago.Id_cliente = int.Parse(txtDniCliente.Text);
            medioPago.Id = int.Parse(txtId.Text);
            medioPago.Id_Tipo_Tarjeta = gestor.BuscarId(cmbTiposTarjetas.Text);
            medioPago.NroTarjeta = int.Parse(txtNroTarjeta.Text);
            medioPago.FechaCaducidad = txtFecha.Value;
            medioPago.Cvv = int.Parse(txtCvv.Text);
            if (!gestor.modificar(medioPago))
            {
                MessageBox.Show("No se pudo modificar"); return;
            }
            MessageBox.Show("Se modificó correctamente");
            mostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") { MessageBox.Show("Rellene campos");  }
            EntityMedioPago medioPago = new EntityMedioPago();
            medioPago.Id = int.Parse(txtId.Text);
            if (!gestor.eliminar(medioPago))
            {
                MessageBox.Show("No se pudo eliminar"); return;
            }
            MessageBox.Show("Se eliminó correctamente");
            mostrarLista();
        }

        private void DGmediosView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = DGmediosView.Rows[e.RowIndex];
            txtId.Text = selectedRow.Cells["Id"].Value.ToString();
            txtDniCliente.Text = selectedRow.Cells["Id_cliente"].Value.ToString();
            cmbTiposTarjetas.Text = selectedRow.Cells["Id_Tipo_Tarjeta"].Value.ToString();
            txtNroTarjeta.Text = selectedRow.Cells["NroTarjeta"].Value.ToString();
            txtFecha.Value = (DateTime)selectedRow.Cells["FechaCaducidad"].Value;
            txtCvv.Text = selectedRow.Cells["Cvv"].Value.ToString();
        }
    }
}
