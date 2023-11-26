using Business;
using Entity;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormMedioPago : ServiceForm
    {
        Cliente _formCliente;
        public FormMedioPago(Cliente formCliente)
        {
            _formCliente = formCliente;
            InitializeComponent();
        }

        private void MostrarLista()
        {
            lbl_DG.DG.Rows.Clear();
            foreach (var medios in gestor.listar().Data)
            {
                lbl_DG.DG.Rows.Add(medios.NroTarjeta, medios.Id_Tipo_Tarjeta, medios.Id_cliente, medios.FechaCaducidad, medios.Cvv);
            }
        }

        private void crearDG()
        {
            lbl_DG.DG.AutoGenerateColumns = false;
            lbl_DG.DG.Columns.Add("Nro Tarjeta", "Nro Tarjeta");
            lbl_DG.DG.Columns.Add("Tipo Tarjeta", "Tipo Tarjeta");
            lbl_DG.DG.Columns.Add("Dni Cliente", "DNI cliente");
            lbl_DG.DG.Columns.Add("Fecha Caducidad", "Fecha Caducidad");
            lbl_DG.DG.Columns.Add("Codigo Seguridad", " Codigo Seguridad");
        }

        BusinessMedioPago gestor = new BusinessMedioPago();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _formCliente.Show();
            this.Close();
        }

        private void DGmediosView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            txtDni.Text = lbl_DG.DG.Rows[e.RowIndex].Cells["Dni cliente"].Value.ToString();
            lbl_txtBox.txt.Text = lbl_DG.DG.Rows[e.RowIndex].Cells["Nro Tarjeta"].Value.ToString();
            lbl_cmb.cmb.Text = lbl_DG.DG.Rows[e.RowIndex].Cells["Tipo Tarjeta"].Value.ToString();
            txtCvv.Text = lbl_DG.DG.Rows[e.RowIndex].Cells["Codigo Seguridad"].Value.ToString();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntityTipoTarjeta tarj = (EntityTipoTarjeta)lbl_cmb.cmb.SelectedItem;
                EntityMedioPago medio = new EntityMedioPago
                {
                    Id_cliente = int.Parse(txtDni.Text),
                    NroTarjeta = int.Parse(lbl_txtBox.txt.Text),
                    FechaCaducidad = datePick.Value,
                    Cvv = int.Parse(txtCvv.Text),
                    Id_Tipo_Tarjeta = tarj.Id,
                };
                this.RevisarRespuestaServicio(gestor.agregar(medio));
                MostrarLista();
            }
            catch
            {
                MessageBox.Show("Rellene Campos o arregle formato");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntityMedioPago medio = new EntityMedioPago();
                medio.NroTarjeta = int.Parse(lbl_txtBox.txt.Text);
                this.RevisarRespuestaServicio(gestor.eliminar(medio));
                MostrarLista();
            }
            catch
            {
                MessageBox.Show("Error en el formato");
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntityTipoTarjeta tarj = (EntityTipoTarjeta)lbl_cmb.cmb.SelectedItem;
                EntityMedioPago medio = new EntityMedioPago
                {
                    Id_cliente = int.Parse(txtDni.Text),
                    NroTarjeta = int.Parse(lbl_txtBox.txt.Text),
                    FechaCaducidad = datePick.Value,
                    Cvv = int.Parse(txtCvv.Text),
                    Id_Tipo_Tarjeta = tarj.Id,
                };
                this.RevisarRespuestaServicio(gestor.modificar(medio));
                MostrarLista();
            }
            catch
            {
                MessageBox.Show("Rellene Campos o arregle formato");
            }
        }

        private void FormMedioPago_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            lbl_cmb.cmb.DataSource = gestor.tiposTarjeta;
            lbl_cmb.cmb.DisplayMember = "Nombre";
            crearDG();
            MostrarLista();
            lbl_txtBox.lbl.Text = "Numero de Tarjeta";
            lbl_DG.lbl.Text = "Medios de pago:";
            lbl_cmb.lbl.Text = "Tipo Tarejta";
        }
    }
}
