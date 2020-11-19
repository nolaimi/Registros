using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Registros.DAO
{
    class conexion
    {
        protected SqlConnection conexion = new SqlConnection("server=D20A0758/SQLEXPRESS;database=patrones;integrate security= true");
    }
}
