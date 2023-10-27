using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;

namespace Business
{
    public class BusinessProducto
    {
        DataAccessProducto MPproducto = new DataAccessProducto();
        public List<EntityCategoria> categorias;

        public BusinessProducto()
        {
          categorias = MPproducto.LoadCategorias();
        }

        public BusinessRespuesta<bool> agregar(EntityProducto producto )
        {
            if (string.IsNullOrEmpty(producto.Nombre) || string.IsNullOrEmpty(producto.Descripcion))
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");
           
            return MPproducto.Insert(producto) ?
                new BusinessRespuesta<bool>(true, true, "Agregado Correctamente!") :
                new BusinessRespuesta<bool>(false, false, "Error al agregar");
        }

        public BusinessRespuesta<bool> eliminar(string id)
        {
            try
            {
                return MPproducto.Delete(int.Parse(id)) ?
                      new BusinessRespuesta<bool>(true, true, "Se eliminó correctamente!") :
                      new BusinessRespuesta<bool>(false, false, "No se pudó eliminar, revise el id solicitado");
            }
            catch 
            {
                return new BusinessRespuesta<bool>(false, false, " Formato incorrecto en el ID");
            }
        }

        public BusinessRespuesta<List<EntityProducto>> listar()
        {
            try
            {
                return new BusinessRespuesta<List<EntityProducto>>(true, MPproducto.SelectAll());
            }
            catch (Exception)
            {
                return new BusinessRespuesta<List<EntityProducto>>(false, null, "Ha ocurrido un error en la busqueda");
            }
        }

        public BusinessRespuesta<bool> modificar(EntityProducto producto )
        {
            if (string.IsNullOrEmpty(producto.Nombre) || string.IsNullOrEmpty(producto.Descripcion))
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");
            if (MPproducto.Update(producto))
                return new BusinessRespuesta<bool>(true, true, "Modificado Correctamente!");
            else
            {
                return new BusinessRespuesta<bool>(false, false, "Error al modificar");
            }
        }
    }
}
