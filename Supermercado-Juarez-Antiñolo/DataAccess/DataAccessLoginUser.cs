using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAccessLoginUser
    {

        private readonly DBConnection conect;

        public DataAccessLoginUser()
        {
            conect = DBConnection.GetInstance;
        }
    }
}
