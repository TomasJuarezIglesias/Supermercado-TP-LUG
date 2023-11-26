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
    public partial class Cliente : Form
    {
        EntityLoginUser _loginUser;
        public Cliente(EntityLoginUser user)
        {
            InitializeComponent();
            _loginUser = user;
            lblSaludo.Text = $"{user.Nombre} {user.Apellido}!";
        }

        private void btnAgregarMedioPago_Click(object sender, EventArgs e)
        {
            FormMedioPago formMedioPago = new FormMedioPago(this);
            formMedioPago.Show();
            this.Hide();
        }
    }
}
