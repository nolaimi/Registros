using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Registros.DTO;




namespace Registros.DAO
{
    class librosDAO : conexion
    {
        SqlDataReader leerfilas;
        SqlCommand comando = new SqlCommand();

        public List<libro> VerRegistros(string condicion)
        {
            comando.Connection = conexion;
            comando.CommandText = "VerRegistros";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@condicion", condicion);

            conexion.Open();

            leerfilas = comando.ExecuteReader();
            List<libro> ListaGenerica = new List<libro>();
            while (leerfilas.Read())
            {
                ListaGenerica.Add(new libro
                {
                    ID = leerfilas.GetInt32(0),
                    NOMBRE = leerfilas.GetString(1),
                    GENERO = leerfilas.GetString(2),
                });


            }
            leerfilas.Close();
            conexion.Close();
            return ListaGenerica;


        }
        public void insert() { }
        public void edit() { }
        public void delete() { }


    }
}
