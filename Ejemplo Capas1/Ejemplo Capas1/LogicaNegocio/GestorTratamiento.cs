using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejemplo_Capas1
{
    class GestorTratamiento
    {
        private SqlConnection con;
        public string AsignarTratamiento(Tratamientos tra)
        {
            con = Conexion.GetConexion();
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = con;
            consulta.CommandText = "insert into tblTratamientos(TraIdPaciente,TraFechaAsignado,TraDetalles,TraFechaIni,TraFechaFin,TraObservaciones) values(@TraIdPaciente,@TraFechaAsignado,@TraDetalles,@TraFechaIni,@TraFechaFin,@TraObservaciones)";
            consulta.Parameters.AddWithValue("@TraIdPaciente", tra.TraIdPaciente);
            consulta.Parameters.AddWithValue("@TraFechaAsignado", tra.TraFechaAsignado);
            consulta.Parameters.AddWithValue("@TraDetalles", tra.TraDetalles);
            consulta.Parameters.AddWithValue("@TraFechaIni", tra.TraFechaIni);
            consulta.Parameters.AddWithValue("@TraFechaFin", tra.TraFechaFin);
            consulta.Parameters.AddWithValue("@TraObservaciones", tra.TraObservaciones);

            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
                    return "Funcionó";
                }
                else
                { 
                    return "Error en la consulta"; 
                }
            }
            catch (Exception ex) 
            {
                return $"Ocurrio un error: {ex.Message}";
            }

        }

    }
}
