using Business;
using Entity;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCliente : ServiceForm
    {
        public FormCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            mostrarLista();
        }

        private void mostrarLista()
        {
            DGclienteView.DataSource = null;
            DGclienteView.DataSource = gestor.listar().Data;
        }

        BusinessCliente gestor = new BusinessCliente();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormInicio frm = new FormInicio();
            frm.Show();
            this.Close();
        }

        private void DGclienteView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex is -1) { return; }
            txtDni.Text = DGclienteView.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
            txtNombre.Text = DGclienteView.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellido.Text = DGclienteView.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtTelefono.Text = DGclienteView.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            EntityCliente cliente = new EntityCliente();
            try
            {
                cliente.Dni = int.Parse(txtDni.Text);
                cliente.Telefono = int.Parse(txtTelefono.Text);
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                this.RevisarRespuestaServicio(gestor.Agregar(cliente));
                mostrarLista();
            }
            catch
            {
                MessageBox.Show("Formato incorrecto en DNI o telefono");
                return;
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
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

        private void btnModificar_Click_1(object sender, EventArgs e)
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


        private void btnMetodosPago_Click(object sender, EventArgs e)
        {
            FormMedioPago frm = new FormMedioPago();
            frm.Show();
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (gestor.xml())
            {
                MessageBox.Show("Impresion correcta!"); return;
            }
            MessageBox.Show("Error en la impresion");
        }
    }
}
