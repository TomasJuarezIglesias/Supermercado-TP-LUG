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
        List<EntityCategoria> categorias = new List<EntityCategoria>();

        public bool agregar(EntityProducto producto)
        {
            return MPproducto.Create(producto);
        }

        public bool eliminar(int id)
        {
            return MPproducto.delete(id);
        }

        public List<EntityProducto> listar()
        {
            return MPproducto.listar();
        }

        public List<string> LoadCategorias()
        {
            categorias = MPproducto.LoadCategorias();
            List<string> result = new List<string>();
            foreach (var categoria in categorias)
            {
                result.Add(categoria.Nombre);
            }
            return result;
        }

        public bool modificar(EntityProducto producto)
        {
            return MPproducto.Update(producto);
        }

        public int obtenerIdCategoria(string nombre)
        {
            
           foreach (var categoria in categorias)
            {
                if (categoria.Nombre.Equals(nombre))
                {
                    return categoria.Id;
                }
            }
            return 0;
        }
    }
}
