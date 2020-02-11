using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmConvertir : Form

       
    {

        private int x;

        public int X { get => x; set => x = value; }

        public frmConvertir()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            x = 88;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            x = 99;
        }
    }
}
