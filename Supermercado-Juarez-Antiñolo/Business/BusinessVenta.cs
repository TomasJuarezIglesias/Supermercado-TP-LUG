using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;

namespace Business
{
    public class BusinessVenta
    {
        DataAccessVenta MPventa = new DataAccessVenta();
        public List<EntityDetalle> detallesActuales = new List<EntityDetalle>();

        public int getId()
        {
            return MPventa.getId();
        }

        public BusinessRespuesta<bool> agregar(EntityVenta venta)
        {
            if ( MPventa.insert(venta) && MPventa.insertDetails(detallesActuales))
            {
                return new BusinessRespuesta<bool>(true, true, "Se registro la venta");
            }
            return new BusinessRespuesta<bool>(false, false, "No se pudo completar la venta");
            
        }
    }
}
