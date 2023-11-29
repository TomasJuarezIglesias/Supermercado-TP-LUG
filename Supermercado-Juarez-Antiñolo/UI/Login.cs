using Bunifu.UI.WinForms;
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
    public partial class Login : ServiceForm
    {
        public Login()
        {
            InitializeComponent();
            _businessLogin = new BusinessLoginUser();
            this.AcceptButton = btnIniciarSesion;
        }


        BusinessLoginUser _businessLogin;

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(dni) && string.IsNullOrEmpty(password))
            {
                mostrarError("Debe Ingresar DNI", lblErrorDni);
                mostrarError("Debe Ingresar Password", lblErrorPass);
                return;
            }

            if (string.IsNullOrEmpty(dni)) { mostrarError("Debe Ingresar DNI", lblErrorDni); return; }

            if (string.IsNullOrEmpty(password)) { mostrarError("Debe Ingresar Password", lblErrorPass); return; }

            if (!int.TryParse(dni, out int _)) { mostrarError("Formato del Dni Incorrecto, Ingrese solo numeros", lblErrorDni); return; }


            EntityLoginUser user = _businessLogin.Login(password, Convert.ToInt32(dni));

            if (user is null)
            {
                mostrarError("Verifique DNI", lblErrorDni);
                mostrarError("Verifique Password", lblErrorPass);
                return;
            }

            if (user.Admin)
            {
                // Redireccion a vista admin
                FormAdministrador formInicioAdmin = new FormAdministrador(user);
                formInicioAdmin.Show();
                this.Hide();
                return;
            }

            // Redireccion a vista cliente
            FormCliente formCliente = new FormCliente(user);
            formCliente.Show();
            this.Hide();
            return;
        }

        void mostrarError(string mensaje, BunifuLabel lbl)
        {
            lbl.Text = mensaje;
            lbl.Visible = true;
        }


        private void txtDni_Click(object sender, EventArgs e)
        {
            if (lblErrorDni.Visible)
            {
                lblErrorDni.Text = "";
                lblErrorDni.Visible = false;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (lblErrorPass.Visible)
            {
                lblErrorPass.Text = "";
                lblErrorPass.Visible = false;
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Hide();
        }

        public void LimpiarCampos()
        {
            txtDni.Text = "";
            txtPassword.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
