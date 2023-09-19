using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessMedioPago
    {

        List<EntityTipoTarjeta> tiposTarjeta = new List<EntityTipoTarjeta>();
        DataAccessMedioPago MPmedioPago = new DataAccessMedioPago();

        public bool agregar(EntityMedioPago medioPago)
        {
            return MPmedioPago.insert(medioPago);
        }

        public int BuscarId(string nombre)
        {
            foreach (var item in tiposTarjeta)
            {
                if(nombre == item.Nombre)
                {
                    return item.Id;
                }
            }
            return 0;
        }

        public bool eliminar(EntityMedioPago medioPago)
        {
            return MPmedioPago.delete(medioPago);
        }

        public List<EntityMedioPago> listar()
        {
            return MPmedioPago.selectAll();
        }

        public List<EntityTipoTarjeta> loadTipoTarjeta()
        {
            tiposTarjeta = MPmedioPago.selectTipoTarjeta();
            return tiposTarjeta;
        }

        public bool modificar(EntityMedioPago medioPago)
        {
            return MPmedioPago.Update(medioPago);
        }
    }
}
