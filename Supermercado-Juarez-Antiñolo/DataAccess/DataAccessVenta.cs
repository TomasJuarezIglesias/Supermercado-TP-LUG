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
    public class DataAccessVenta
    {

        DBConnection conect = new DBConnection();

        public int getId()
        {
            DataTable table = new DataTable();
            table = conect.Read("getIdVenta", null);
            return table.Rows[0][0] != null ? (int)table.Rows[0][0] : 0;
        }

        public bool insert(EntityVenta venta)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@In_nro_venta", venta.Id),
                new SqlParameter("@In_id_cliente", venta.ID_Cliente),
                new SqlParameter("@In_total", venta.Total),
                new SqlParameter("@In_fecha", venta.Fecha),
                new SqlParameter("@In_nro_tarjeta" , venta.Nro_Tarjeta)
            };
            return conect.Write("insert_venta", parameters);
        }

        public bool insertDetails(List<EntityDetalle> detallesActuales)
        {
            foreach (var item in detallesActuales)
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@In_nro_venta" ,item.Nro_Venta),
                    new SqlParameter("@In_id_producto" , item.Id_Producto),
                    new SqlParameter("@In_cant_producto" , item.CantProducto),
                    new SqlParameter("@In_subtotal", item.SubTotal),
                };
                if (!conect.Write("insert_detail", parameters)) return false;
            }
            return true;
        }
    }
}
