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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btn_mesas_Click(object sender, EventArgs e)
        {
            ListaProductos newList = new ListaProductos();
            newList.ShowDialog();
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            ListaProductos newList = new ListaProductos();
            newList.ShowDialog();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Formularios newList = new Formularios();
            newList.ShowDialog();
        }

        private void btn_nosotros_Click(object sender, EventArgs e)
        {
            Formularios newList = new Formularios();
            newList.ShowDialog();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
