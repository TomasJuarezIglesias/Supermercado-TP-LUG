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
    public partial class FormComprar : ServiceForm
    {
        public FormComprar()
        {
            InitializeComponent();
            cargarCmb();
            crearDG();
            actualizar();
        }

        BusinessVenta gestor = new BusinessVenta();
        BusinessProducto gestorProducto = new BusinessProducto();
        BusinessCliente gestorClientes = new BusinessCliente();
        BusinessMedioPago GestorMedioPago = new BusinessMedioPago();

        int montoAcumulado;
        int ventaActual;

        private void crearDG()
        {
            DGdetalleView.AutoGenerateColumns = false;
            DGdetalleView.Columns.Add("NombreProducto", "Nombre Producto");
            DGdetalleView.Columns.Add("Cantidad", "Cantidad");
            DGdetalleView.Columns.Add("Sub total", "Sub total");
        }

        private void actualizar()
        {
            ventaActual = gestor.getId();
            lblNroVenta.Text = ventaActual.ToString();
            montoAcumulado = 0;
            lblMonto.Text = "0";
            DGdetalleView.Rows.Clear();
        }

        private void cargarCmb()
        {
            cmbProducto.DataSource = null;
            cmbDni.DataSource = null;
            cmbProducto.DataSource = gestorProducto.listar().Data;
            cmbProducto.DisplayMember = "Nombre";
            cmbDni.DataSource = gestorClientes.listar().Data;
            cmbDni.DisplayMember = "Dni";
        }

        private void btnAgregarProdu_Click(object sender, EventArgs e)
        {
            try
            {
                EntityDetalle detail = new EntityDetalle
                {
                    Nro_Venta = ventaActual,
                    Id_Producto = gestorProducto.listar().Data.FirstOrDefault(item => cmbProducto.Text == item.Nombre).Id,
                    CantProducto = (int)numericCantidad.Value,
                    SubTotal = (int)((int)numericCantidad.Value * gestorProducto.listar().Data.FirstOrDefault(item => cmbProducto.Text == item.Nombre).Precio),
                };
                gestor.detallesActuales.Add(detail);
                mostrarLista();
            }
            catch
            {
                MessageBox.Show("Error en el formato");
            }
        }

        private void mostrarLista()
        {
            DGdetalleView.Rows.Clear();
            foreach (var item in gestor.detallesActuales)
            {
                DGdetalleView.Rows.Add( gestorProducto.listar().Data.FirstOrDefault(producto => item.Id_Producto == producto.Id).Nombre , item.CantProducto, item.SubTotal);
                montoAcumulado += item.SubTotal;
            }
            lblMonto.Text = montoAcumulado.ToString();
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                EntityVenta venta = new EntityVenta
                {
                    Id = ventaActual,
                    ID_Cliente = int.Parse(cmbDni.Text),
                    Total = montoAcumulado,
                    Fecha = datePick.Value,
                    Nro_Tarjeta = int.Parse(cmbTarjeta.Text),
                };
                if (montoAcumulado <= 0) { MessageBox.Show("Agregue productos antes de finalizar"); return; }
                this.RevisarRespuestaServicio(gestor.agregar(venta));
                actualizar();
            }
            catch
            {
                MessageBox.Show("Campos incompletos o incorrectos");
            }
        }

        private void DGdetalleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex is -1) { return; }
            DialogResult res = MessageBox.Show("Desea borrar el producto seleccionado?" , "Confirmación" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                gestor.detallesActuales.Remove(gestor.detallesActuales[e.RowIndex]);
                mostrarLista();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormInicio frm = new FormInicio();
            frm.Show();
            this.Close();
        }

        private void cmbDni_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbTarjeta.Items.Clear();
            foreach (var item in GestorMedioPago.listar().Data)
            {
                if(item.Id_cliente.ToString() == cmbDni.Text)
                {
                    cmbTarjeta.Items.Add(item.NroTarjeta);
                }
            }
        }
    }
}
