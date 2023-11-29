using DataAccess;
using Entity;
using System.Collections.Generic;

namespace Business
{
    public class BusinessMedioPago
    {
        public BusinessMedioPago()
        {
            tiposTarjeta = MPmedioPago.selectTipoTarjeta();
        }

        public List<EntityTipoTarjeta> tiposTarjeta;
        DataAccessMedioPago MPmedioPago = new DataAccessMedioPago();

        public BusinessRespuesta<bool> agregar(EntityMedioPago medioPago, string nroTarjeta, string cvv)
        {
            if(!int.TryParse(nroTarjeta, out int _nro )|| !int.TryParse(cvv, out int _cvv)){ return new BusinessRespuesta<bool>(false, false, "Error en los campos"); }
            medioPago.NroTarjeta = _nro;
            medioPago.Cvv = _cvv;
            return MPmedioPago.insert(medioPago) ?
                 new BusinessRespuesta<bool>(true, true, "Se agregó exitosamente!") :
                 new BusinessRespuesta<bool>(false, false, "Error. No se pudo agregar");
        }

        public BusinessRespuesta<bool> eliminar(string nroTarjeta)
        {
            if (string.IsNullOrEmpty(nroTarjeta) || !int.TryParse(nroTarjeta , out int _nro)) { return new BusinessRespuesta<bool>(false, false, "Error en el nro de tarjeta"); }
            EntityMedioPago medio = new EntityMedioPago();
            medio.NroTarjeta = _nro;

            return MPmedioPago.delete(medio) ?
                new BusinessRespuesta<bool>(true, true, "Se eliminó correctamente!") :
                new BusinessRespuesta<bool>(false, false, "Error, no se pudo eliminar");
        }

        public BusinessRespuesta<List<EntityMedioPago>> listar()
        {
            try
            {
                return new BusinessRespuesta<List<EntityMedioPago>>(true, MPmedioPago.selectAll());
            }
            catch
            {
                return new BusinessRespuesta<List<EntityMedioPago>>(false, null, "Ha ocurrido un error");
            }
        }

        public BusinessRespuesta<bool> modificar(EntityMedioPago medioPago , string nroTarjeta, string cvv)
        {
            if (!int.TryParse(nroTarjeta, out int _nro) || !int.TryParse(cvv, out int _cvv)) { return new BusinessRespuesta<bool>(false, false, "Error en los campos"); }
            medioPago.NroTarjeta = _nro;
            medioPago.Cvv = _cvv;

            return MPmedioPago.Update(medioPago) ?
            new BusinessRespuesta<bool>(true, true, "Se modificó correctamente") :
            new BusinessRespuesta<bool>(false, false, "No se pudo modificar");
        }
    }
}
