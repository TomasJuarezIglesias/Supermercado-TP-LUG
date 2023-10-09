using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //clase de mapeo accesible desde todas los DataAccess
    internal static class SqlMapper
    {
        public static EntityCliente MapCliente(DataRow registro)
        {
            return new EntityCliente()
            {
                Dni = int.Parse(registro["dni"].ToString()),
                Nombre = registro["nombre"].ToString(),
                Apellido = registro["apellido"].ToString(),
                Telefono = int.Parse(registro["telefono"].ToString()),
            };
        }

        public static EntityCategoria MapCategoria(DataRow registro)
        {
            return new EntityCategoria()
            {
                Id = int.Parse(registro["id"].ToString()),
                Nombre = registro["nombre"].ToString(),
                Descripcion = registro["descripcion"].ToString(),
            };
        }

        public static EntityMedioPago MapMedioPago(DataRow registro)
        {
            return new EntityMedioPago()
            {
                Id_cliente = int.Parse(registro["id_cliente"].ToString()),
                Id_Tipo_Tarjeta = int.Parse(registro["id_tipo_tarjeta"].ToString()),
                NroTarjeta = int.Parse(registro["nro_tarjeta"].ToString()),
                FechaCaducidad = (DateTime)registro["fecha_caducidad"],
                Cvv = int.Parse(registro["cvv"].ToString()),
            };
        }

        public static EntityTipoTarjeta MapTipoTarjeta(DataRow registro)
        {
            return new EntityTipoTarjeta()
            {
                Id = int.Parse(registro["id"].ToString()),
                Nombre = registro["nombre"].ToString(),
            };
        }

        public static EntityProducto MapProducto(DataRow registro)
        {
            return new EntityProducto()
            {
                Id = int.Parse(registro["id"].ToString()),
                Nombre = registro["nombre"].ToString(),
                Descripcion = registro["descripcion"].ToString(),
                Id_Categoria = int.Parse(registro["id_categoria"].ToString()),
                Precio = double.Parse(registro["precio"].ToString()),
                Stock = int.Parse(registro["stock"].ToString()),
            };
        }
    }
}
