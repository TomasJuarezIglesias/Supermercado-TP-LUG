using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAccessCiente
    {
        DBConnection conn = new DBConnection();

        public bool delete(EntityCliente cliente)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_dni" , cliente.Dni)
            };
            return conn.Write("delete_cliente", parameters);
        }

        public bool Insert(EntityCliente cliente)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_dni" , cliente.Dni),
                new SqlParameter("In_nombre" , cliente.Nombre),
                new SqlParameter("In_apellido" , cliente.Apellido),
                new SqlParameter("In_telefono" , cliente.Telefono)
            };
            return conn.Write("insert_cliente", parameters);
        }

        public List<EntityCliente> SelectAll()
        {
            DataTable table = new DataTable();
            List<EntityCliente> list = new List<EntityCliente>();
            table = conn.Read("select_cliente", null);
            foreach( DataRow registro in table.Rows )
            {
                EntityCliente cliente = new EntityCliente();
                cliente.Dni = int.Parse(registro["dni"].ToString());
                cliente.Nombre = registro["nombre"].ToString();
                cliente.Apellido = registro["apellido"].ToString();
                cliente.Telefono = registro["telefono"].ToString() ;
                list.Add(cliente);
            }
            return list;
        }

        public bool Update(EntityCliente cliente)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_dni" , cliente.Dni),
                new SqlParameter("In_nombre" , cliente.Nombre),
                new SqlParameter("In_apellido" , cliente.Apellido),
                new SqlParameter("In_telefono" , cliente.Telefono)
            };
            return conn.Write("update_cliente", parameters);
        }
    }
}
