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
    public partial class FormMedioPago : ServiceForm
    {
        public FormMedioPago()
        {
            InitializeComponent();
            cmbTarjeta.DataSource = gestor.tiposTarjeta;
            cmbTarjeta.DisplayMember = "Nombre";
            crearDG();
            MostrarLista();
        }

        private void MostrarLista()
        {
            DGmediosView.Rows.Clear();
            EntityTipoTarjeta tarj = (EntityTipoTarjeta)cmbTarjeta.SelectedItem;
            foreach (var medios in gestor.listar().Data)
            {
                DGmediosView.Rows.Add(medios.NroTarjeta, tarj.Id , medios.Id_cliente , medios.FechaCaducidad , medios.Cvv);
            }
        }

        private void crearDG()
        {
            DGmediosView.AutoGenerateColumns = false;
            DGmediosView.Columns.Add("Nro Tarjeta", "Nro Tarjeta");
            DGmediosView.Columns.Add("Tipo Tarjeta", "Tipo Tarjeta");
            DGmediosView.Columns.Add("Dni Cliente", "DNI cliente");
            DGmediosView.Columns.Add("Fecha Caducidad", "Fecha Caducidad");
            DGmediosView.Columns.Add("Codigo Seguridad", " Codigo Seguridad");
        }

        BusinessMedioPago gestor = new BusinessMedioPago();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntityTipoTarjeta tarj = (EntityTipoTarjeta)cmbTarjeta.SelectedItem;
                EntityMedioPago medio = new EntityMedioPago
                {
                    Id_cliente = int.Parse(txtDni.Text),
                    NroTarjeta = int.Parse(txtNumeroTarjeta.Text),
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EntityMedioPago medio = new EntityMedioPago();
                medio.NroTarjeta = int.Parse(txtNumeroTarjeta.Text);
                this.RevisarRespuestaServicio(gestor.eliminar(medio));
                MostrarLista();
            }
            catch
            {
                MessageBox.Show("Error en el formato");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntityTipoTarjeta tarj = (EntityTipoTarjeta)cmbTarjeta.SelectedItem;
                EntityMedioPago medio = new EntityMedioPago
                {
                    Id_cliente = int.Parse(txtDni.Text),
                    NroTarjeta = int.Parse(txtNumeroTarjeta.Text),
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Show();
            this.Hide();
        }
    }
}
