using Business;
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

namespace UI
{
    public partial class FormDetalles : ServiceForm
    {
        public FormDetalles()
        {
            InitializeComponent();
            cargarCmb();
            crearDG();
        }

        private void crearDG()
        {
            DGdetallesView.AutoGenerateColumns = false;
            DGdetallesView.Columns.Add("NombreProducto", "Nombre Producto");
            DGdetallesView.Columns.Add("Cantidad", "Cantidad");
            DGdetallesView.Columns.Add("Sub total", "Sub total");
            DGventaView.AutoGenerateColumns = false;
            DGventaView.Columns.Add("Cliente", "Cliente");
            DGventaView.Columns.Add("Total", "Total");
            DGventaView.Columns.Add("Medio de Pago", "Medio de Pago");
        }

        private void cargarCmb()
        {
            cmbDetalles.DataSource = gestor.listarVentas().Data;
            cmbDetalles.DisplayMember = "Id";
        }

        BusinessVenta gestor = new BusinessVenta();
        BusinessProducto gestorProducto = new BusinessProducto();
        BusinessCliente gestorClientes = new BusinessCliente();

        private void btnMostrarDetalles_Click(object sender, EventArgs e)
        {
            DGventaView.Rows.Clear();
            foreach (var item in gestor.listarVentas().Data)
            {
                if (item.Id.ToString() == cmbDetalles.Text)
                {
                    EntityCliente cliente = gestorClientes.listar().Data.FirstOrDefault(cl => cl.Dni == item.ID_Cliente);
                    DGventaView.Rows.Add(cliente.Nombre + "" + cliente.Apellido, item.Total, item.Fecha);
                }
            }
            DGdetallesView.Rows.Clear();
            foreach (var item in gestor.listarDetalles(cmbDetalles.Text).Data)
            {
                EntityProducto prod = gestorProducto.listar().Data.FirstOrDefault(producto => item.Id_Producto == producto.Id);
                DGdetallesView.Rows.Add(prod.Nombre, item.CantProducto, item.SubTotal);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormInicio frm = new FormInicio();
            frm.Show();
            this.Close();
        }
    }
}
