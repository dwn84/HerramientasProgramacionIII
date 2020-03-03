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
    public partial class frmListadoTra : Form
    {
        public frmListadoTra()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GestorTratamiento gt = new GestorTratamiento();
            DataTable data = new DataTable();
            data.Load(gt.BuscarTratamiento(txtCedula.Text));
            dataGridView1.DataSource = data;
        }
    }
}
