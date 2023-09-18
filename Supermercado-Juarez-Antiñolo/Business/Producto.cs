using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Producto
    {
        DataAccess.Producto MPproducto = new DataAccess.Producto();

        public bool agregar(Entity.Producto producto)
        {
            return MPproducto.Create(producto);
        }

        public bool eliminar(int id)
        {
            return MPproducto.delete(id);
        }

        public List<Entity.Producto> listar()
        {
            return MPproducto.listar();
        }

        public List<string> LoadCategorias()
        {
            return MPproducto.LoadCategorias();
        }

        public bool modificar(Entity.Producto producto)
        {
            return MPproducto.Update(producto);
        }

        public int obtenerIdCategoria(string nombre)
        {
           return MPproducto.obtenerIdCat(nombre);
        }
    }
}
