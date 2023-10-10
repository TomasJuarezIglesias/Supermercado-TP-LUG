using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;
namespace Business
{
    public class BusinessCategoria
    {

        DataAccessCategoria MPcat = new DataAccessCategoria();

        public BusinessRespuesta<bool> Agregar(EntityCategoria categoria)
        {
            if (string.IsNullOrEmpty(categoria.Nombre) || string.IsNullOrEmpty(categoria.Descripcion))
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");
            return MPcat.Insert(categoria) ?
            new BusinessRespuesta<bool>(true, true, "Agregado correctamente!") :
            new BusinessRespuesta<bool>(false, false, "Error al agregar");
        }

        public BusinessRespuesta<bool> Eliminar(int id)
        {
            EntityCategoria categoria = new EntityCategoria() { Id = id };
            return MPcat.Delete(categoria) ?
                 new BusinessRespuesta<bool>(true, true, $"Se elimino la categoria {id} satisfactoriamente") :
                    new BusinessRespuesta<bool>(false, false, "Formato incorrecto para la categoria");
        }

        public BusinessRespuesta<List<EntityCategoria>> Listar()
        {
            try
            {
                return new BusinessRespuesta<List<EntityCategoria>>(true, MPcat.SelectAll());
            }
            catch (Exception)
            {
                return new BusinessRespuesta<List<EntityCategoria>>(false, null, "Ha ocurrido un error en la busqueda");
            }
        }

        public BusinessRespuesta<bool> Modificar(EntityCategoria categoria)
        {
            if (string.IsNullOrEmpty(categoria.Nombre) || string.IsNullOrEmpty(categoria.Descripcion))
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");

            return MPcat.Update(categoria) ?
                 new BusinessRespuesta<bool>(true, true, "Se modificó correctamente!") :
                    new BusinessRespuesta<bool>(false, false, "Elija una categoria");

        }
    }
}
