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
    public partial class frmRangoTratamientos : Form
    {

        GestorTratamiento gt = new GestorTratamiento();

        public frmRangoTratamientos()
        {
            InitializeComponent();
        }

        private void frmRangoTratamientos_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            gt.BuscarTratamientoFechas(dtpInicio.Value, dtpFin.Value, dgvResultados);
        }
    }
}
