using Newtonsoft.Json;
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
    public partial class FechaIndividual : Form
    {
        Funciones funFunciones = new Funciones();
        List<InterfaceProductos> AllProductos = new List<InterfaceProductos>();
        VentasDiarias Venta = new VentasDiarias();

        public FechaIndividual(int id)
        {
            InitializeComponent();
            todosLosProductos();
            AsiganrValoresDelDia(id);
            FormateDataStruct();
        }

        private void todosLosProductos()
        {
            AllProductos = funFunciones.ProductGetAll();
        }

        private void AsiganrValoresDelDia(int id)
        {
            //JsonConvert.SerializeObject -> a string
            //JsonConvert.DeserializeObject -> de string
            VentasDiarias dia = funFunciones.VentaDGet(id);
            Venta = dia;

            if (dia == null) {
                MessageBox.Show("Error con los Datos intente de nuevo...");
                this.Close();
            }

            List<ProductosMesa> NewData = JsonConvert.DeserializeObject<List<ProductosMesa>>(dia.productos);

            if (NewData == null) return;
            Label_Cantidad.Text = "Cant. Prod: " + NewData.Count.ToString();

            List<ProductosMesaVista> Data = new List<ProductosMesaVista>();

            foreach (ProductosMesa ProdMesa in NewData)
            {
                foreach (InterfaceProductos Produc in AllProductos)
                {
                    if (Produc.id == ProdMesa.id)
                    {
                        ProductosMesaVista nwData = new ProductosMesaVista();
                        nwData.id = ProdMesa.id;
                        nwData.nombre = Produc.nombre;
                        nwData.cantidad = ProdMesa.cantidad;
                        nwData.precio = ProdMesa.cantidad * Produc.precio;

                        Data.Add(nwData);
                    }
                }
            }

            DataDay.DataSource = Data;
        }

        private void FormateDataStruct()
        {
            Label_Precio.Text = "Valor Total: $" + Venta.total.ToString();
            DataDay.Columns[0].Visible = false;

            DataDay.Columns[1].Width = 350;
            DataDay.Columns[2].Width = 150;
            DataDay.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataDay.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataDay.Columns[3].Width = 150;
            DataDay.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataDay.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataDay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataDay.CurrentCell = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fechaIndividual_Load(object sender, EventArgs e)
        {

        }
    }
}
