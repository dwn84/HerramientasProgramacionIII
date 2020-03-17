using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Ejemplo_Capas1
{
    class Conexion
    {

        private static SqlConnection con;

        public static SqlConnection GetConexion() 
     
        {
            con = new SqlConnection("Data Source=SYN\\SQLEXPRESS; Initial Catalog=DBTratamientos; Integrated Security=True; MultipleActiveResultSets=True");
            try
            {
                con.Open();
                Debug.WriteLine("Conexión satisfactoria");
                return con;
            }
            catch (Exception ex) 
            {
                Debug.WriteLine($"Ocurrio un error en la conexión: {ex.Message}");
                return null;
            }
        }

    }
}
