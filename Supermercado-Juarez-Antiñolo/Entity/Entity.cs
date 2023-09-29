using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Entity
    {
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

	}
}
