using Business;
using Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormComprar : ServiceForm
    {
        public FormComprar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargarCmb();
            crearDG();
            actualizar();
            cmbProducto.SelectedIndex = -1;
            cmbDni.SelectedIndex = -1;
            lbl_numeric.lbl.Text = "Cantidad";
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
            gestor.detallesActuales.Clear();
            lbl_numeric.numeric.Value = 1;
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


        private void mostrarLista()
        {
            DGdetalleView.Rows.Clear();
            montoAcumulado = 0;
            foreach (var item in gestor.detallesActuales)
            {
                DGdetalleView.Rows.Add(gestorProducto.listar().Data.FirstOrDefault(producto => item.Id_Producto == producto.Id).Nombre, item.CantProducto, item.SubTotal);
                montoAcumulado += item.SubTotal;
            }
            lblMonto.Text = montoAcumulado.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormInicio frm = new FormInicio();
            if (montoAcumulado > 0)
            {
                foreach (var item in gestor.detallesActuales)
                {
                    CancelarProductoVenta(item);
                }
            }
            frm.Show();
            this.Close();
        }

        private void cmbDni_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbTarjeta.Items.Clear();
            foreach (var item in GestorMedioPago.listar().Data)
            {
                if (item.Id_cliente.ToString() == cmbDni.Text)
                {
                    cmbTarjeta.Items.Add(item);
                }
                cmbTarjeta.DisplayMember = "NroTarjeta";
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            if (montoAcumulado > 0)
            {
                foreach (var item in gestor.detallesActuales)
                {
                    CancelarProductoVenta(item);
                }
            }
            frm.Show();
            this.Close();
        }

        private void DGdetalleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex is -1) { return; }
            DialogResult res = MessageBox.Show("Desea borrar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                CancelarProductoVenta(gestor.detallesActuales[e.RowIndex]);
                gestor.detallesActuales.Remove(gestor.detallesActuales[e.RowIndex]);
                mostrarLista();
            }
        }

        private void CancelarProductoVenta(EntityDetalle item)
        {
            foreach (var producto in gestorProducto.listar().Data)
            {
                if (producto.Id == item.Id_Producto)
                {
                    producto.Stock += item.CantProducto;
                    gestorProducto.modificar(producto);
                }
            }
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EntityProducto prod = (EntityProducto)cmbProducto.SelectedItem;
            lbl_numeric.numeric.Maximum = prod.Stock;
            if (prod.Stock <= 0) { MessageBox.Show("No hay stock del producto seleccionado"); cmbProducto.SelectedIndex = -1; }
        }

        private void btnFinalizarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                EntityVenta venta = new EntityVenta
                {
                    Id = ventaActual,
                    ID_Cliente = int.Parse(cmbDni.Text),
                    Total = montoAcumulado,
                    Fecha = DateTime.Now,
                    Nro_Tarjeta = int.Parse(cmbTarjeta.Text),
                };
                this.RevisarRespuestaServicio(gestor.agregar(venta));
                actualizar();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique los datos ingresados");
            }
        } 

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(cmbProducto.SelectedIndex == -1 || lbl_numeric.numeric.Value.Equals(0))
            {
                string mensaje = cmbProducto.SelectedIndex is -1 ? "Debe seleccionar un producto" : "No se puede agregar cantidad = 0";
                MessageBox.Show(mensaje);
                return;
            }

            EntityProducto prod = (EntityProducto)cmbProducto.SelectedItem;

            EntityDetalle detail = new EntityDetalle
            {
                Nro_Venta = ventaActual,
                Id_Producto = prod.Id,
                CantProducto = (int)lbl_numeric.numeric.Value,
                SubTotal = (int)((int)lbl_numeric.numeric.Value * prod.Precio),
            };
            prod.Stock -= (int)lbl_numeric.numeric.Value;
            gestorProducto.modificar(prod);
            cmbProducto.SelectedIndex = -1;
            lbl_numeric.numeric.Value = 1;
            gestor.detallesActuales.Add(detail);
            mostrarLista();
        }

        
    }
}
