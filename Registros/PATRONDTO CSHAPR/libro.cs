using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.DTO
{
    class libro
    {
        int _ID;
        string _NOMBRE;
        string _GENERO;

        public int ID { get => _ID; set => _ID = value; }

        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string GENERO { get => _GENERO; set => _GENERO = value; }
    }

    
   
}
