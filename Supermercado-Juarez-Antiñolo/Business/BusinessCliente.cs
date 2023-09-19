using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;
namespace Business
{
    public class BusinessCliente
    {
        
        DataAccessCiente Mpcliente = new DataAccessCiente();

        public bool Agregar(EntityCliente cliente)
        {
            return Mpcliente.Insert(cliente);
        }

        public bool Eliminar(EntityCliente cliente)
        {
           return Mpcliente.delete(cliente);
        }

        public List<EntityCliente> listar()
        {
           return Mpcliente.SelectAll();
        }

        public bool Modificar(EntityCliente cliente)
        {
            return Mpcliente.Update(cliente);
        }
    }
}
