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
    public partial class FormProducto : ServiceForm
    {
        public FormProducto()
        {
            InitializeComponent();
            foreach (var item in gestor.categorias)
            {
                cmbCategoria.Items.Add(item.Nombre);
            }
            MostrarLista();
        }

        private void MostrarLista()
        {
            DGproductoView.DataSource = null;
            DGproductoView.DataSource = gestor.listar().Data;
        }

        BusinessProducto gestor = new BusinessProducto();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EntityProducto producto = new EntityProducto();
            try
            {
                producto.Precio = int.Parse(txtPrecio.Text);
                producto.Stock = int.Parse(txtStock.Text);
            }
            catch 
            {
                MessageBox.Show("Formato incorrecto de algun dato");
                return;
            }
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            this.RevisarRespuestaServicio(gestor.agregar( producto, cmbCategoria.Text));
            MostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.RevisarRespuestaServicio(gestor.eliminar(txtId.Text));
            MostrarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EntityProducto producto = new EntityProducto();
            try
            {
                producto.Precio = int.Parse(txtPrecio.Text);
                producto.Stock = int.Parse(txtStock.Text);
                producto.Id = int.Parse(txtId.Text);
            }
            catch
            {
                MessageBox.Show("Formato incorrecto de algun dato");
                return;
            }
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            this.RevisarRespuestaServicio(gestor.modificar(producto, cmbCategoria.Text));
            MostrarLista();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormInicio frm = new FormInicio();
            frm.Show();
            this.Close();
        }
    }
}
