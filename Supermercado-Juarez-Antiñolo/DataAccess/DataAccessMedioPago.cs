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
    public class DataAccessMedioPago
    {
        DBConnection conn = new DBConnection();

        public bool delete(EntityMedioPago medioPago)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("In_id" , medioPago.Id),
            };
            return conn.Write("delete_medio_pago", parameters);
        }

        public bool insert(EntityMedioPago medioPago)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_id_cliente" , medioPago.Id_cliente),
                new SqlParameter("In_tipo_tarjeta" , medioPago.Id_Tipo_Tarjeta),
                new SqlParameter("In_nro_tarjeta" , medioPago.NroTarjeta),
                new SqlParameter("In_fecha_caducidad", medioPago.FechaCaducidad),
                new SqlParameter("In_cvv" , medioPago.Cvv)
            };
            return conn.Write("insert_medio_pago", parameters);
        }

        public List<EntityMedioPago> selectAll()
        {
            List<EntityMedioPago> list = new List<EntityMedioPago>();
            DataTable table = new DataTable();
            table = conn.Read("select_medio_pago", null);
            foreach (DataRow registro in table.Rows)
            {
                EntityMedioPago medio = new EntityMedioPago();
                medio.Id =  int.Parse(registro["id"].ToString());
                medio.Id_cliente = int.Parse(registro["id_cliente"].ToString());
                medio.Id_Tipo_Tarjeta = int.Parse(registro["id_tipo_tarjeta"].ToString());
                medio.NroTarjeta = int.Parse(registro["nro_tarjeta"].ToString()) ;
                medio.FechaCaducidad = (DateTime)registro["fecha_caducidad"];
                medio.Cvv = int.Parse(registro["cvv"].ToString());
                list.Add(medio);
            }
            return list;
        }

        public List<EntityTipoTarjeta> selectTipoTarjeta()
        {
            List<EntityTipoTarjeta> list = new List<EntityTipoTarjeta>();
            
            DataTable table = new DataTable();
            table = conn.Read("select_tipo_tarjeta", null);
            foreach (DataRow registro in table.Rows)
            {
                EntityTipoTarjeta tipo = new EntityTipoTarjeta();
                tipo.Id = int.Parse(registro["id"].ToString());
                tipo.Nombre = registro["nombre"].ToString();
                list.Add(tipo);
            }
            return list;
        }

        public bool Update(EntityMedioPago medioPago)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("In_id" , medioPago.Id),
            new SqlParameter ("In_id_cliente", medioPago.Id_cliente),
            new SqlParameter("In_tipo_tarjeta" , medioPago.Id_Tipo_Tarjeta),
            new SqlParameter("In_nro_tarjeta", medioPago.NroTarjeta),
            new SqlParameter("In_fecha_caducidad" , medioPago.FechaCaducidad),
            new SqlParameter("In_cvv", medioPago.Cvv)
            };
            return conn.Write("update_medio_pago", parameters);
        }
    }
}
