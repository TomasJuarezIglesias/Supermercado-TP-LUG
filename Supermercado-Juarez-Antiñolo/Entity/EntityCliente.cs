using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityCliente
    {
		private int _dni;

		public int Dni
		{
			get { return _dni; }
			set { _dni = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private string _telefono;

		public string Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}

		private int _nroTarjeta;

		public int NroTarjeta
		{
			get { return _nroTarjeta; }
			set { _nroTarjeta = value; }
		}


	}
}
