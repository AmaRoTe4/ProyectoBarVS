using System.Runtime.Caching;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using AplicacionBar.Properties;
using Newtonsoft.Json;

namespace AplicacionBar
{
    public partial class Mesas : Form
    {
        List<InterfaceProductos> AllProductos= new List<InterfaceProductos>();
        Funciones funFunciones = new Funciones();
        List<Button> mesasList = new List<Button>();
        InterfaceMesas MesaSelect = new InterfaceMesas();

        private void asignarValoresDeMesas()
        {
            if (MesaSelect == null) return;
            if (MesaSelect.productos_vendidos == "") return;

            List<ProductosMesa> Productos = JsonConvert.DeserializeObject<List<ProductosMesa>>(MesaSelect.productos_vendidos);

            if (Productos == null) return;

            listarProductosDeMesa(Productos);
        }

        private void VerMesas()
        {
            string vistas = (string)Settings.Default["VistasMesas"];

            if (vistas == null) return;

            for (int i = 0; i < vistas.Length; i++)
            {
                mesasList[i].Visible = true;
            }

        }

        private void agregarMesa()
        {
            foreach (Button mesa in mesasList)
            {
                if (!mesa.Visible)
                {
                    mesa.Visible = true;
                    break;
                }
            }
        }

        private void borrarMesa()
        {
            bool condicion = true;
            int id = 36;

            while (condicion && id > 0)
            {
                id--;
                if (mesasList[id].Visible == true) condicion = false;
            }

            if (id != -1) mesasList[id].Visible = false;
        }

        private void listarProductosDeMesa(List<ProductosMesa> NewData)
        {
            if (NewData == null) return;
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

            DataCompra.DataSource = Data;

            //id oculto
            DataCompra.Columns[0].Visible = false;
            //nombre
            DataCompra.Columns[1].Width = 250;
            //cantida
            DataCompra.Columns[2].Width = 250;
            DataCompra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //precio total
            DataCompra.Columns[3].Width = 250;
            DataCompra.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            DataCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataCompra.CurrentCell = null;
        }

        //funcion en mesas individuales
        private void AgregarProductoALaMesa(ProductosMesa newProducto)
        {
            if(MesaSelect.productos_vendidos == "" || MesaSelect.productos_vendidos == null)
            {
                List<ProductosMesa> Productos = new List<ProductosMesa>();
                Productos.Add(newProducto);
                MesaSelect.productos_vendidos = JsonConvert.SerializeObject(Productos);
            }
            else
            {
                List<ProductosMesa> oldProductos = JsonConvert.DeserializeObject<List<ProductosMesa>>(MesaSelect.productos_vendidos);
                if (oldProductos == null || oldProductos.Count == 0) return;
                bool condicion = false;

                foreach (ProductosMesa oldProducto in oldProductos)
                {
                    if (oldProducto.id == newProducto.id) { 
                        oldProducto.cantidad += newProducto.cantidad;
                        condicion = true;
                        break;
                    } 
                }
                
                if(!condicion) oldProductos.Add(newProducto);
                
                MesaSelect.productos_vendidos = JsonConvert.SerializeObject(oldProductos);
            }
            asignarValoresDeMesas();
        }

        private void EliminarProductoALaMesa(int id)
        {
            if (id == null) return;

            List<ProductosMesa> oldProductos = JsonConvert.DeserializeObject<List<ProductosMesa>>(MesaSelect.productos_vendidos);

            if (oldProductos == null || oldProductos.Count == 0) return;

            int i = 0;

            foreach (ProductosMesa oldProducto in oldProductos)
            {
                if (oldProducto.id == id) break;
                else i++;

            }

            oldProductos.RemoveAt(i);
            MesaSelect.productos_vendidos = JsonConvert.SerializeObject(oldProductos);
            asignarValoresDeMesas();
        }

        private void listarProductos(List<InterfaceProductos> NewData = null)
        {
            if (NewData == null)
            {
                List<InterfaceProductos> productos = funFunciones.ProductGetAll();
                AllProductos = productos;
                DataProductos.DataSource = productos;
            }
            else
            {
                DataProductos.DataSource = NewData;
            }
            DataProductos.Columns[0].Visible = false;
            DataProductos.Columns[1].Width = 250;
            DataProductos.Columns[2].Visible = false;
            DataProductos.Columns[3].Width = 250;
            DataProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataProductos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataProductos.CurrentCell = null;
        }

        private void AgregarMesas()
        {
            mesasList.Add(btnMesa1);
            mesasList.Add(btnMesa2);
            mesasList.Add(btnMesa3);
            mesasList.Add(btnMesa4);
            mesasList.Add(btnMesa5);
            mesasList.Add(btnMesa6);
            mesasList.Add(btnMesa7);
            mesasList.Add(btnMesa8);
            mesasList.Add(btnMesa9);
            mesasList.Add(btnMesa10);
            mesasList.Add(btnMesa11);
            mesasList.Add(btnMesa12);
            mesasList.Add(btnMesa13);
            mesasList.Add(btnMesa14);
            mesasList.Add(btnMesa15);
            mesasList.Add(btnMesa16);
            mesasList.Add(btnMesa17);
            mesasList.Add(btnMesa18);
            mesasList.Add(btnMesa19);
            mesasList.Add(btnMesa20);
            mesasList.Add(btnMesa21);
            mesasList.Add(btnMesa22);
            mesasList.Add(btnMesa23);
            mesasList.Add(btnMesa24);
            mesasList.Add(btnMesa25);
            mesasList.Add(btnMesa26);
            mesasList.Add(btnMesa27);
            mesasList.Add(btnMesa28);
            mesasList.Add(btnMesa29);
            mesasList.Add(btnMesa30);
            mesasList.Add(btnMesa31);
            mesasList.Add(btnMesa32);
            mesasList.Add(btnMesa33);
            mesasList.Add(btnMesa34);
            mesasList.Add(btnMesa35);
            mesasList.Add(btnMesa36);
        }

        private void AlertaBorrado()
        {
            string message = "Si quiero BORRAR el producto seleccione si";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                EliminarProductoALaMesa(Convert.ToInt32(DataCompra.SelectedRows[0].Cells[0].Value));
            }
        }

        public Mesas()
        {
            InitializeComponent();
            AgregarMesas();
            listarProductos();
            VerMesas();
        }

        private void Mesas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            agregarMesa();
        }


        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {
            borrarMesa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = false;
            this.ControlBox = true;

            //guardar cambios
            funFunciones.MesasEdita(MesaSelect.id, MesaSelect);
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(1);
            Label_N_mesa.Text = "Mesa N°1";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(2);
            Label_N_mesa.Text = "Mesa N°2";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(3);
            Label_N_mesa.Text = "Mesa N°3";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(4);
            Label_N_mesa.Text = "Mesa N°4";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(5);
            Label_N_mesa.Text = "Mesa N°5";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(6);
            Label_N_mesa.Text = "Mesa N°6";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(7);
            Label_N_mesa.Text = "Mesa N°7";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
            MesaSelect = funFunciones.MesasGet(8);
            Label_N_mesa.Text = "Mesa N°8";
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //este es el boton 9
            panelMesaNum.Visible = true;
            MesaSelect = funFunciones.MesasGet(9);
            Label_N_mesa.Text = "Mesa N°9";
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(10);
            Label_N_mesa.Text = "Mesa N°10";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(11);
            Label_N_mesa.Text = "Mesa N°11";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(12);
            Label_N_mesa.Text = "Mesa N°12";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa13_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(13);
            Label_N_mesa.Text = "Mesa N°13";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa14_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(14);
            Label_N_mesa.Text = "Mesa N°14";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa15_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(15);
            Label_N_mesa.Text = "Mesa N°15";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa16_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(16);
            Label_N_mesa.Text = "Mesa N°16";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa17_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(17);
            Label_N_mesa.Text = "Mesa N°17";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa18_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(18);
            Label_N_mesa.Text = "Mesa N°18";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa19_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(19);
            Label_N_mesa.Text = "Mesa N°19";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa20_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(20);
            Label_N_mesa.Text = "Mesa N°20";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa21_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(21);
            Label_N_mesa.Text = "Mesa N°21";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa22_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(22);
            Label_N_mesa.Text = "Mesa N°22";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa23_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(23);
            Label_N_mesa.Text = "Mesa N°23";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa24_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(24);
            Label_N_mesa.Text = "Mesa N°24";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa25_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(25);
            Label_N_mesa.Text = "Mesa N°25";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa26_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(26);
            Label_N_mesa.Text = "Mesa N°26";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa27_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(27);
            Label_N_mesa.Text = "Mesa N°27";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa28_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(28);
            Label_N_mesa.Text = "Mesa N°28";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa29_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(29);
            Label_N_mesa.Text = "Mesa N°29";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa30_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(30);
            Label_N_mesa.Text = "Mesa N°30";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }

        private void btnMesa31_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(31);
            Label_N_mesa.Text = "Mesa N°31";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }
        private void btnMesa32_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(32);
            Label_N_mesa.Text = "Mesa N°32";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }
        private void btnMesa33_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(33);
            Label_N_mesa.Text = "Mesa N°33";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }
        private void btnMesa34_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(34);
            Label_N_mesa.Text = "Mesa N°34";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }
        private void btnMesa35_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(35);
            Label_N_mesa.Text = "Mesa N°35";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }
        private void btnMesa36_Click(object sender, EventArgs e)
        {
            MesaSelect = funFunciones.MesasGet(36);
            Label_N_mesa.Text = "Mesa N°36";
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            this.ControlBox = false;
        }
        private void panelMesaNum_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccionesDeMesas_Click(object sender, EventArgs e)
        {

        }

        private void labNombre_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textBoxCantidad.Text) < 1)
            {
                MessageBox.Show("La Cantidad debe ser mayor o igual a 1");
                return;
            }
            if(DataProductos.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar un Producto");
                return;
            }

            ProductosMesa newProducto = new ProductosMesa();

            newProducto.id = Convert.ToInt32(DataProductos.SelectedRows[0].Cells[0].Value);
            newProducto.cantidad = Convert.ToInt32(textBoxCantidad.Text);

            textBoxCantidad.Text = "1";

            if (newProducto.id == null)
            {
                MessageBox.Show("Asigancion Erronea");
                return;
            }

            AgregarProductoALaMesa(newProducto);
        }

        private void txtBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            List<InterfaceProductos> newProductos = new List<InterfaceProductos>();

            foreach (InterfaceProductos indidualProducto in AllProductos)
            {
                if (indidualProducto.nombre.ToLower().Contains(txtBoxBuscador.Text.ToLower())) newProductos.Add(indidualProducto);
            }

            listarProductos(newProductos);
        }

        private void Mesas_FormClosing(object sender, FormClosingEventArgs e)
        {
            string newString = "";

            foreach (Button mesa in mesasList)
            {
                if(mesa.Visible) newString = newString + "0";
            }

            Settings.Default["VistasMesas"] = newString;
        }

        private void DataCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlertaBorrado();
        }

        private void DataCompra_KeyDown(object sender, KeyEventArgs e)
        {
            AlertaBorrado();
        }
    }
}
