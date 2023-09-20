using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Business;
using Entity;
namespace Supermercado_Juarez_Antiñolo
{
    
    public partial class FormCategorias : MetroForm
    {
        public FormCategorias()
        {
            InitializeComponent();
            mostrarLista();
        }
        BusinessCategoria gestor = new BusinessCategoria();
        EntityCategoria categoria;

        private void mostrarLista()
        {
            DGcatView.DataSource = null;
            DGcatView.DataSource = gestor.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDescripcion.Text == "") { MessageBox.Show("Rellene campos"); return; }
            categoria = new EntityCategoria();
            categoria.Nombre = txtNombre.Text;
            categoria.Descripcion = txtDescripcion.Text;
            if (!gestor.agregar(categoria))
            {
                MessageBox.Show("No se pudo agregar");
                return;
            }
            MessageBox.Show("Se agregó correctamente");
            mostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == ""  ){ MessageBox.Show("Rellene campos"); return; }
            categoria = new EntityCategoria();
            categoria.Id = int.Parse(txtId.Text);
            if (!gestor.Eliminar(categoria))
            {
                MessageBox.Show("No se pudo eliminar");
                return;
            }
            MessageBox.Show("Se elimino correctamente");
            mostrarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "") { MessageBox.Show("Rellene campos"); return; }
            categoria = new EntityCategoria();
            categoria.Id = int.Parse(txtId.Text);
            categoria.Nombre = txtNombre.Text;
            categoria.Descripcion = txtDescripcion.Text;
            if (!gestor.modificar(categoria))
            {
                MessageBox.Show("No se pudo modificar");
                return;
            }
            MessageBox.Show("Se modifico correctamente");
            mostrarLista();
        }

        private void DGcatView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = DGcatView.Rows[e.RowIndex];
            txtId.Text = selectedRow.Cells["Id"].Value.ToString();
            txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
        }
    }
}
