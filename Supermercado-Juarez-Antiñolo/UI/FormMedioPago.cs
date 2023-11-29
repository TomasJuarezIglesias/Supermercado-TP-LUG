using Business;
using Entity;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormMedioPago : ServiceForm
    {
        FormCliente _formCliente;
        EntityLoginUser _user;

        public FormMedioPago(FormCliente formCliente, EntityLoginUser user)
        {
            _formCliente = formCliente;
            _user = user;
            InitializeComponent();
        }


        BusinessMedioPago gestor = new BusinessMedioPago();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _formCliente.Show();
            this.Close();
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

            EntityTipoTarjeta tarj = (EntityTipoTarjeta)lbl_cmb.cmb.SelectedItem;
            EntityMedioPago medio = new EntityMedioPago
            {
                Id_cliente = _user.IdCliente,
                FechaCaducidad = datePick.Value,
                Id_Tipo_Tarjeta = tarj.Id,
            };
            this.RevisarRespuestaServicio(gestor.agregar(medio, lbl_txtBox.txt.Text, txtCvv.Text));
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            this.RevisarRespuestaServicio(gestor.eliminar(lbl_txtBox.txt.Text));
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

            EntityTipoTarjeta tarj = (EntityTipoTarjeta)lbl_cmb.cmb.SelectedItem;
            EntityMedioPago medio = new EntityMedioPago
            {
                Id_cliente = _user.IdCliente,
                FechaCaducidad = datePick.Value,
                Id_Tipo_Tarjeta = tarj.Id,
            };
            this.RevisarRespuestaServicio(gestor.modificar(medio, lbl_txtBox.txt.Text , txtCvv.Text));
        }

        private void FormMedioPago_Load(object sender, EventArgs e)
        {
            lbl_cmb.cmb.DataSource = gestor.tiposTarjeta;
            lbl_cmb.cmb.DisplayMember = "Nombre";
            lbl_txtBox.lbl.Text = "Numero de Tarjeta";
            lbl_cmb.lbl.Text = "Tipo Tarejta";
        }
    }
}
