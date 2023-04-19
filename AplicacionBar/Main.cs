using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionBar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_mesas_Click(object sender, EventArgs e)
        {
            Mesas windows = new Mesas();
            windows.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos windows = new Productos();
            windows.ShowDialog();
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            Totales windows = new Totales();
            windows.ShowDialog();
        }

        private void btn_nosotros_Click(object sender, EventArgs e)
        {
            Nosotros windows = new Nosotros();
            windows.ShowDialog();
        }
    }
}
