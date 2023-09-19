using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace DataAccess
{
    
    public class DataAccessProducto
    {
        DBConnection conect = new DBConnection();

        public bool Create(Entity.EntityProducto producto)
        {
            SqlParameter[] parameters = new SqlParameter[]{
             new SqlParameter("In_nombre", producto.Nombre),
            new SqlParameter("In_descripcion", producto.Descripcion),
            new SqlParameter("In_id_categoria", producto.Id_Categoria),
            new SqlParameter("In_precio", producto.Precio),
            new SqlParameter("In_stock", producto.Stock) };
            return conect.Write("insert_producto" , parameters);
        }

        public bool delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("In_id", id);
            return conect.Write("delete_Producto", parameters);
        }

        public List<EntityProducto> listar()
        {
            List<EntityProducto> list = new List<EntityProducto>();
            DataTable table = new DataTable();
            table = conect.Read("select_Productos", null);
            foreach(DataRow registro in table.Rows)
            {
                EntityProducto prod = new EntityProducto();
                prod.Id =int.Parse(registro["id"].ToString());
                prod.Nombre = registro["nombre"].ToString();
                prod.Descripcion = registro["descripcion"].ToString();
                prod.Id_Categoria = int.Parse(registro["id_categoria"].ToString());
                prod.Precio = double.Parse(registro["precio"].ToString());
                prod.Stock = int.Parse(registro["stock"].ToString() );
                list.Add( prod );
            }
            return list;
        }
            
        public List<EntityCategoria> LoadCategorias()
        {
            List<EntityCategoria> list = new List<EntityCategoria>();
            DataTable table = new DataTable();
            table = conect.Read("select_categoria", null);
            foreach (DataRow registro in table.Rows)
            {
                EntityCategoria cat= new EntityCategoria();
                cat.Id     = int.Parse(registro["id"].ToString());
                cat.Nombre = registro["nombre"].ToString();
                list.Add(cat);
            }
            return list;
        }

        
        public bool Update(EntityProducto producto)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("In_id", producto.Id),
            new SqlParameter("In_nombre", producto.Nombre),
            new SqlParameter("In_descripcion", producto.Descripcion),
            new SqlParameter("In_id_categoria", producto.Id_Categoria),
            new SqlParameter("In_precio", producto.Precio),
            new SqlParameter("In_stock", producto.Stock) };

            return conect.Write("update_producto", parameters);
        }
    }
}
