using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejemplo_Capas1
{
    public partial class frmPaciente : Form
    {

        BindingSource bs;
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection ccc;

        public frmPaciente()
        {
            InitializeComponent();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            ccc = Conexion.GetConexion();
            string sql = "select * from tblPacientes";

            SqlCommand exeSql = new SqlCommand(sql, ccc);

            da = new SqlDataAdapter(sql, ccc);

            SqlCommandBuilder contruirConsultas = new SqlCommandBuilder(da);

            SqlDataReader registros = exeSql.ExecuteReader();

            dt = new DataTable();
            dt.Load(registros);

            bs = new BindingSource();
            bs.DataSource = dt;

            bindingNavigator1.BindingSource = bs;

            dataGridView1.DataSource = bs;

            txtCedula.DataBindings.Add(new Binding("text", bs, "PacId"));
            txtNombre.DataBindings.Add(new Binding("text", bs, "PacNombres"));
            txtSexo.DataBindings.Add(new Binding("text", bs, "PacSexo"));
            dtpFechaN.DataBindings.Add(new Binding("text", bs, "PacFechaN"));
            txtApellido .DataBindings.Add(new Binding("text", bs, "PacApellidos"));

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            da.Update(dt);
        }
    }
}
