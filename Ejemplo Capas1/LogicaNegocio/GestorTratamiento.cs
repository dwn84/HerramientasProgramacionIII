using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ejemplo_Capas1
{
    class GestorTratamiento
    {
        private SqlConnection con;
        public void AsignarTratamiento(Tratamientos tra)
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

            string mensaje = "";

            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
                    mensaje = "Funcionó";
                }
                else
                {
                    mensaje = "Error en la consulta";
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Ocurrio un error inesperado: {ex.Message}";
            }

            System.Windows.Forms.MessageBox.Show(mensaje);

        }

        public SqlDataReader BuscarTratamiento(string id) {
            con = Conexion.GetConexion();
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = con;
            consulta.CommandText = "select * from tblTratamientos where TraIdPaciente = @idp";
            consulta.Parameters.AddWithValue("@idp", id);
            return consulta.ExecuteReader();
        }

        public void ListadoPacientes(System.Windows.Forms.ComboBox listado)
        {
            con = Conexion.GetConexion();
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = con;
            consulta.CommandText = "select PacId from tblPacientes";
            //SqlDataReader data=  consulta.ExecuteReader();
            //while (data.Read()) {
            //    listado.Items.Add(data["PacId"]);
            //}
            SqlDataAdapter registros = new SqlDataAdapter("select PacId,PacNombres from tblPacientes", con);
            DataTable dt = new DataTable();
            registros.Fill(dt);
            listado.DataSource = dt;
            listado.DisplayMember = "PacNombres";
            listado.ValueMember = "PacId";
            

        }

        public void BuscarTratamientoFechas(DateTime ini, DateTime fin, System.Windows.Forms.DataGridView listado)
        {
            con = Conexion.GetConexion();
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = con;
            consulta.CommandText = "select p.PacNombres, t.TraDetalles from tblPacientes as p "+
                                                "join tblTratamientos as t on p.PacId = t.TraIdPaciente "+
                                                "where t.TraFechaIni between @i and @f";
            consulta.Parameters.AddWithValue("@i", ini);
            consulta.Parameters.AddWithValue("@f", fin);

            DataTable data = new DataTable();
            data.Load(consulta.ExecuteReader());
            listado.DataSource = data;

        }

    }
}
