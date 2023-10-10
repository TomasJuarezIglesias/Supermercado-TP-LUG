using Entity;
using Business;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UI
{
    public partial class FormCategoria : ServiceForm
    {
        public FormCategoria()
        {
            InitializeComponent(); 
            CrearDG();
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            DGcatView.Rows.Clear();
            foreach (var cat in gestor.Listar().Data)
            {
                DGcatView.Rows.Add(cat.Nombre, cat.Descripcion);
            }
        }

        private void CrearDG()
        {
            DGcatView.AutoGenerateColumns = false;
            DGcatView.Columns.Add("Nombre", "Nombre");
            DGcatView.Columns.Add("Descripcion", "Descripcion");
        }
            BusinessCategoria gestor = new BusinessCategoria();

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            EntityCategoria categoria = new EntityCategoria();
            categoria.Nombre = txtNombre.Text;
            categoria.Descripcion = txtCategoria.Text;
            this.RevisarRespuestaServicio(gestor.Agregar(categoria));
            MostrarDatos();
        }
        private void DGcatView_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex is -1) { return; }
            DialogResult res = MessageBox.Show("Presione SI para eliminar \nPresione NO para modificar ", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                
            }
            if(res== DialogResult.No)
            {
                EntityCategoria categoria = new EntityCategoria
                {
                    Id = gestor.Listar().Data[e.RowIndex].Id,
                    Nombre = txtNombre.Text,
                    Descripcion = txtCategoria.Text
                };
                this.RevisarRespuestaServicio(gestor.Modificar(categoria));
                MostrarDatos();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormInicio frm = new FormInicio();
            frm.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto();
            frm.Show();
            this.Close();
        }
    }
}
