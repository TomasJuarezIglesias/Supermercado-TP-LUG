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
            cmbCategoria.DataSource = gestor.categorias;
            cmbCategoria.DisplayMember = "Nombre";
            crearDG();
            MostrarLista();
        }
        BusinessProducto gestor = new BusinessProducto();
        private void crearDG()
        {
            DGproductoView.AutoGenerateColumns = false;
            DGproductoView.Columns.Add("CodigoProducto", "CodigoProducto"); // El primer "" es el nombre de la propiedad, el segundo es el encabezado de la columna
            DGproductoView.Columns.Add("Nombre", "Nombre");
            DGproductoView.Columns.Add("Descripcion", "Descripcion");
            DGproductoView.Columns.Add("Categoria", "Categoria");
            DGproductoView.Columns.Add("Precio", "Precio");
            DGproductoView.Columns.Add("Stock", "Stock");
        } 

        //Se esta cargando la categoria con la actual del cmb, falta buscar con cada producto la correspondiente categoria
        private void MostrarLista()
        {
            DGproductoView.Rows.Clear();
            
            foreach (var item in gestor.listar().Data)
            {
                string cat = gestor.categorias.FirstOrDefault(cate => cate.Id == item.Id_Categoria).Nombre;
                DGproductoView.Rows.Add(item.Id, item.Nombre, item.Descripcion, cat , item.Precio, item.Stock);
            }
    }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EntityProducto producto = new EntityProducto();
            try
            {
                EntityCategoria categoria = (EntityCategoria)cmbCategoria.SelectedItem;
                producto.Id_Categoria = categoria.Id;
                producto.Precio = int.Parse(txtPrecio.Text);
                producto.Stock = int.Parse(txtStock.Text);
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                this.RevisarRespuestaServicio(gestor.agregar(producto));
                MostrarLista();
            }
            catch 
            {
                MessageBox.Show("Formato incorrecto de algun dato");
            }
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
                EntityCategoria categoria = (EntityCategoria)cmbCategoria.SelectedItem;
                producto.Id_Categoria = categoria.Id;
                producto.Precio = int.Parse(txtPrecio.Text);
                producto.Stock = int.Parse(txtStock.Text);
                producto.Id = int.Parse(txtId.Text);
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                this.RevisarRespuestaServicio(gestor.modificar(producto));
                MostrarLista();
            }
            catch
            {
                MessageBox.Show("Formato incorrecto de algun dato");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormInicio frm = new FormInicio();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCategoria frm = new FormCategoria();
            frm.Show();
            this.Hide();
        }
    }
}
