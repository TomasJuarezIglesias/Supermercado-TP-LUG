using DataAccess;
using Entity;
using System;
using System.Collections.Generic;

namespace Business
{
    public class BusinessCliente
    {

        DataAccessCiente Mpcliente = new DataAccessCiente();

        public BusinessRespuesta<bool> Agregar(EntityCliente cliente, string dni, string telefono)
        {
            if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.Apellido) || !int.TryParse(dni, out int _dni) || !int.TryParse(telefono, out int _telefono))
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");
            cliente.Dni = _dni;
            cliente.Telefono = _telefono;
            return Mpcliente.Insert(cliente) ?
                new BusinessRespuesta<bool>(true, true, "Agregado Correctamente!") :
                 new BusinessRespuesta<bool>(false, false, "Error al agregar");
        }

        public BusinessRespuesta<bool> Eliminar(string dni)
        {
            if (!int.TryParse(dni, out int _dni)) { return new BusinessRespuesta<bool>(false, false, "No se pudó eliminar, revise el dni solicitado"); }

            EntityCliente cliente = new EntityCliente() { Dni = _dni };
            return Mpcliente.delete(cliente) ?
             new BusinessRespuesta<bool>(true, true, "Eliminado Correctamente!") :
                new BusinessRespuesta<bool>(false, false, "No se pudó eliminar");
        }

        public BusinessRespuesta<List<EntityCliente>> listar()
        {
            try
            {
                return new BusinessRespuesta<List<EntityCliente>>(true, Mpcliente.SelectAll());
            }
            catch (Exception)
            {
                return new BusinessRespuesta<List<EntityCliente>>(false, null, "Ha ocurrido un error en la busqueda");
            }
        }

        public BusinessRespuesta<bool> Modificar(EntityCliente cliente, string dni , string telefono)
        {
            if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.Apellido) || !int.TryParse(dni, out int _dni) || !int.TryParse(telefono, out int _telefono))
            {
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");
            }
            cliente.Dni = _dni;
            cliente.Telefono = _telefono;
            return Mpcliente.Update(cliente) ?
             new BusinessRespuesta<bool>(true, true, "Se modificó Correctamente!") :
                new BusinessRespuesta<bool>(false, false, "Error al modificar");
        }

        public bool xml()
        {
            return Mpcliente.xml();
        }
    }
}
