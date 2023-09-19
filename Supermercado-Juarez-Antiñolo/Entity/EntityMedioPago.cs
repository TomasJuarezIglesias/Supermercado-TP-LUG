using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityMedioPago
    {
		private int _id_cliente;

		public int Id_cliente
		{
			get { return _id_cliente; }
			set { _id_cliente = value; }
		}
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private int _tipoTarjeta;

		public int TipoTarjeta
		{
			get { return _tipoTarjeta; }
			set { _tipoTarjeta = value; }
		}
		private int _nroTarjeta;

		public int NroTarjeta
		{
			get { return _nroTarjeta; }
			set { _nroTarjeta = value; }
		}
		private DateTime _fecha_caducidad;

		public DateTime FechaCaducidad
		{
			get { return _fecha_caducidad; }
			set { _fecha_caducidad = value; }
		}
		private int _cvv;

		public int Cvv
		{
			get { return _cvv; }
			set { _cvv = value; }
		}



	}
}
