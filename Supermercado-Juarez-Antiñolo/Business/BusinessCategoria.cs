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

        public bool agregar(EntityCategoria categoria)
        {
            return MPcat.Insert(categoria);
        }

        public bool Eliminar(EntityCategoria categoria)
        {
            return MPcat.Delete(categoria);
        }

        public List<EntityCategoria> listar()
        {
            return MPcat.selectAll();
        }

        public bool modificar(EntityCategoria categoria)
        {
            return MPcat.Update(categoria);
        }
    }
}
