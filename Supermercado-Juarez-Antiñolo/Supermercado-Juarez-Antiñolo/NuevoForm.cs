using Business;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado_Juarez_Antiñolo
{
    public class NuevoForm: MetroForm
    {
        protected void RevisarRespuestaServicio<T>(BusinessRespuesta<T> respuesta)
        {
            if (!respuesta.Ok)
            {
                MessageBox.Show(respuesta.Mensaje, "Epa!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

            }
        }
    }
}
