using Business;
using Entity;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Supermercado_Juarez_Antiñolo
{
    public partial class FormProducto : MetroForm
    {
        
        public FormProducto()
        {
            InitializeComponent();
            loadCmbCategoria();
            mostrarLista();
        }

        BusinessProducto gestor = new BusinessProducto();
        EntityProducto producto;

        private void loadCmbCategoria()
        {
            List<string> nombres = gestor.LoadCategorias();
            foreach (var nombre in nombres)
            {
                cmbCategorias.Items.Add(nombre);
            }
        }
        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDescripcion.Text == "" || txtNombre.Text == "" || txtStock.Text == "" || cmbCategorias.Text == "")
            {
                MessageBox.Show("Rellene campos");
                return;
            }
            producto = new EntityProducto();
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = double.Parse(txtPrecio.Text);
            producto.Stock = int.Parse(txtStock.Text);
            producto.Id_Categoria = gestor.obtenerIdCategoria(cmbCategorias.Text);
            if (!gestor.agregar(producto))
            {
                MessageBox.Show("No se pudo agregar");
                return;
            }
            MessageBox.Show("Se agrego correctamente");
            mostrarLista();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Rellene campos");
                return;
            }
            if (!gestor.eliminar(int.Parse(txtId.Text)))
            {
                MessageBox.Show("No se pudo eliminar");
            }
            MessageBox.Show("Se elimino correctamente");
            mostrarLista();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || txtNombre.Text == "" || txtStock.Text == "" || cmbCategorias.Text == "")
            {
                MessageBox.Show("Rellene campos");
                return;
            }
            producto = new EntityProducto();
            producto.Id = int.Parse(txtId.Text);
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Id_Categoria = gestor.obtenerIdCategoria(cmbCategorias.Text);
            producto.Precio = double.Parse(txtPrecio.Text);
            producto.Stock = int.Parse(txtStock.Text);
            if (!gestor.modificar(producto))
            {
                MessageBox.Show("No se pudo modificar");
                return;
            }
            MessageBox.Show("Se modificó correctamente");
            mostrarLista();
        }

        private void DGprodView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = DGprodView.Rows[e.RowIndex];
            txtId.Text = selectedRow.Cells["Id"].Value.ToString();
            txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
            cmbCategorias.Text = selectedRow.Cells["Id_Categoria"].Value.ToString();
            txtPrecio.Text = selectedRow.Cells["Precio"].Value.ToString();
            txtStock.Text = selectedRow.Cells["Stock"].Value.ToString();
        }

        void mostrarLista()
        {
            DGprodView.DataSource = null;
            DGprodView.DataSource = gestor.listar();
        }


    }
}
