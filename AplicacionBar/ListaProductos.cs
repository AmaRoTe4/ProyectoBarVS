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
    public partial class ListaProductos : Form
    {
        Funciones funFunciones = new Funciones();
        List<InterfaceProductos> AllProductos = new List<InterfaceProductos>();

        public ListaProductos()
        {
            InitializeComponent();
            List<InterfaceProductos> productos = funFunciones.ProductGetAll();
            GridData.DataSource = productos;
            GridData.Columns[0].Width = 35;
            GridData.Columns[0].HeaderText = "N°";
            GridData.Columns[1].Width = 200;
            GridData.Columns[2].Width = 200;
            GridData.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridData.Columns[3].Width = 200;
            GridData.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            AllProductos = productos;
            GridData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridData.CurrentCell = null;
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {

        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridData.SelectedRows == null || GridData.SelectedRows.Count < 0) return;
            Formularios newList = new Formularios(1, Convert.ToInt32(GridData.SelectedRows[0].Cells[0].Value));
            newList.ShowDialog();
        }

        private void GridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridData_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void GridData_Enter(object sender, EventArgs e)
        {

        }

        private void GridData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GridData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (GridData.SelectedRows == null || GridData.SelectedRows.Count < 0) return;
            Formularios newList = new Formularios(1 , Convert.ToInt32(GridData.SelectedRows[0].Cells[0].Value));
            newList.ShowDialog();
        }
    }
}
