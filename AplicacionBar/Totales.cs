using AplicacionBar.Properties;
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
    public partial class Totales : Form
    {
        Funciones funFunciones = new Funciones();
        public Totales()
        {
            InitializeComponent();
            ListarTotales();
        }

        private void Totales_Load(object sender, EventArgs e)
        {

        }
    
        //private int cantidadDeProductos(string data)
        //{
        //    return 0;
        //}

        private void ListarTotales()
        {
            List<VentasDiarias> productos = funFunciones.VentaDGetAll();
            int dia = (int)Settings.Default["EstadoDia"];
            if (dia != 0) productos.RemoveAt(productos.Count - 1);
            
            GridTotales.DataSource = productos;
            GridTotales.Columns[0].HeaderText = "N°"; 
            GridTotales.Columns[0].Width = 55;

            GridTotales.Columns[1].Width = 80;

            GridTotales.Columns[2].Width = 170;
            GridTotales.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridTotales.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
           

            GridTotales.Columns[3].Visible = false;

            //GridTotales.Columns[4].HeaderText = "Cant. Prod";
            //GridTotales.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //GridTotales.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            GridTotales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridTotales.CurrentCell = null;
        }

        private void GridTotales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridTotales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridTotales.SelectedRows == null || GridTotales.SelectedRows.Count < 0) return;
            FechaIndividual newList = new FechaIndividual(Convert.ToInt32(GridTotales.SelectedRows[0].Cells[0].Value));
            newList.ShowDialog();
        }

        private void GridTotales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (GridTotales.SelectedRows == null || GridTotales.SelectedRows.Count < 0) return;
            FechaIndividual newList = new FechaIndividual(Convert.ToInt32(GridTotales.SelectedRows[0].Cells[0].Value));
            newList.ShowDialog();
        }
    }
}
