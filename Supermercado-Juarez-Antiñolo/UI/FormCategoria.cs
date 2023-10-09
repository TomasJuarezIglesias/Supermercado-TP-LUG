using Entity;
using Business;
using System;

namespace UI
{
    public partial class FormCategoria : ServiceForm
    {
        public FormCategoria()
        {
            InitializeComponent();
            mostarDatos();
        }

        private void mostarDatos()
        {
            DGcatView.DataSource = null;
            DGcatView.DataSource = gestor.Listar().Data;
        }

        BusinessCategoria gestor = new BusinessCategoria();

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            EntityCategoria categoria = new EntityCategoria();
            categoria.Nombre = txtNombre.Text;
            categoria.Descripcion = txtCategoria.Text;
            this.RevisarRespuestaServicio(gestor.Agregar(categoria));
            mostarDatos();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            this.RevisarRespuestaServicio(gestor.Eliminar(txtId.Text));
            mostarDatos();
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            EntityCategoria categoria = new EntityCategoria {
                Nombre = txtNombre.Text,
                Descripcion = txtCategoria.Text};
            this.RevisarRespuestaServicio(gestor.Modificar(txtId.Text, categoria));
            mostarDatos();
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
