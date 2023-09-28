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

        public BusinessRespuesta<bool> agregar(EntityCategoria categoria)
        {
            if (string.IsNullOrEmpty(categoria.Nombre) || string.IsNullOrEmpty(categoria.Descripcion))
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");
            MPcat.Insert(categoria);
            return new BusinessRespuesta<bool>(true, true, "Agregado correctamente!");
        }

        public BusinessRespuesta<bool> Eliminar(string id)
        {
            if (!string.IsNullOrEmpty(id))
                return new BusinessRespuesta<bool>(false, false, "Elija una categoria");
            MPcat.Delete(new EntityCategoria() { Id = int.Parse(id) });
            return new BusinessRespuesta<bool>(true, true, $"Se elimino la categoria {id} satisfactoriamente");
        }

        public BusinessRespuesta<List<EntityCategoria>> listar()
        {
            try
            {
                return new BusinessRespuesta<List<EntityCategoria>>(true, MPcat.selectAll());
            }
            catch (Exception)
            {
                return new BusinessRespuesta<List<EntityCategoria>>(false, null, "Ha ocurrido un error en la busqueda");
            }
        }

        public bool modificar(EntityCategoria categoria)
        {
            return MPcat.Update(categoria);
        }
    }
}
