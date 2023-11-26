using Business;
using Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormProducto : ServiceForm
    {
        FormAdministrador _administrador;
        public FormProducto(FormAdministrador administrador)
        {
            InitializeComponent();
            _administrador = administrador;
            this.StartPosition = FormStartPosition.CenterScreen;
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
                DGproductoView.Rows.Add(item.Id, item.Nombre, item.Descripcion, cat, item.Precio, item.Stock);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _administrador.Show();
            this.Close();
        }

        private void DGproductoView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = DGproductoView.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = DGproductoView.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            txtPrecio.Text = DGproductoView.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
            txtStock.Text = DGproductoView.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
            cmbCategoria.Text = DGproductoView.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            txtId.Text = DGproductoView.Rows[e.RowIndex].Cells["CodigoProducto"].Value.ToString();
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
                producto.Descripcion = txtDescription.Text;
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

        private void btnModificacion_Click(object sender, EventArgs e)
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
                producto.Descripcion = txtDescription.Text;
                this.RevisarRespuestaServicio(gestor.modificar(producto));
                MostrarLista();
            }
            catch
            {
                MessageBox.Show("Formato incorrecto de algun dato");
            }
        }

        private void btnGestionarCate_Click(object sender, EventArgs e)
        {
            FormCategoria frm = new FormCategoria(_administrador, this);
            frm.Show();
            this.Hide();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            if (gestor.xml()) { MessageBox.Show("Impresion correcta"); return;  }
            MessageBox.Show("Error en la impresion");
        }
    }
}
