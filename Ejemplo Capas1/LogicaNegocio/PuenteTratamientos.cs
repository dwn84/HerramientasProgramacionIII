using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejemplo_Capas1
{
    class PuenteTratamientos
    {
        private GestorTratamiento gt;

        public PuenteTratamientos() {
            gt = new GestorTratamiento();
        }

        public void EjecutarIngresoTratamiento(frmAsignarTra formulario) {
           
            //verificar la cédula seleccionada...
            System.Windows.Forms.MessageBox.Show(formulario.txtCedPaciente.SelectedValue.ToString());
            gt.AsignarTratamiento(new Tratamientos
            {
                TraDetalles = formulario.txtDetalle.Text,
                TraFechaAsignado = formulario.dtpFechaA.Value,
                TraFechaFin = formulario.dtpFechaF.Value,
                TraFechaIni = formulario.dtpFechaI.Value,
                TraIdPaciente = formulario.txtCedPaciente.SelectedValue.ToString(),
                TraObservaciones = formulario.txtObservaciones.Text

            });
        }

       

    }
}
