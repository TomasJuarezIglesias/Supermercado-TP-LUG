using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace UI
{
    public class ServiceForm : Form
    {
        protected void RevisarRespuestaServicio<T>(BusinessRespuesta<T> respuesta)
        {
            if (!respuesta.Ok)
            {
                MessageBox.Show(respuesta.Mensaje, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!string.IsNullOrEmpty(respuesta.Mensaje))
                MessageBox.Show(respuesta.Mensaje, "Great!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
