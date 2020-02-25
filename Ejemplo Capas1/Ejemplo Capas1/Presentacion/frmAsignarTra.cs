using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Capas1
{
    public partial class frmAsignarTra : Form
    {
        public frmAsignarTra()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            //delegar resposabilidades
            //capa de datos, recibe la información
            Tratamientos ttt = new Tratamientos
            {
                TraDetalles = txtDetalle.Text,
                TraFechaAsignado = dtpFechaA.Value,
                TraFechaFin = dtpFechaF.Value,
                TraFechaIni = dtpFechaI.Value,
                TraIdPaciente = txtCedPaciente.Text,
                TraObservaciones = txtObservaciones.Text
            };
            //capa de lógica de negocio, procesa la información "insert into"
            GestorTratamiento Tratamiento = new GestorTratamiento();
            MessageBox.Show(Tratamiento.AsignarTratamiento(ttt));
            

        }
    }
}
