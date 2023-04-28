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
using System.Drawing.Printing;

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

            float precioTotal = 0;
            int cantidadTotal = 0;
            
            if(AllProductos.Count == 0)
            {
                MessageBox.Show("Error de Comprobacion");
                return;
            }

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

                        precioTotal += ProdMesa.cantidad * Produc.precio;
                        cantidadTotal += ProdMesa.cantidad;

                        Data.Add(nwData);
                        break;
                    }
                }
            }

            ProductosMesaVista total = new ProductosMesaVista();
            total.id = 0;
            total.nombre = "Total";
            total.cantidad = cantidadTotal;
            total.precio = precioTotal;
            Data.Add(total);

            DataCompra.DataSource = Data;

            DataCompra.Rows[DataCompra.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
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

        private void ActicionesDeDia()
        {
            int dia = (int)Settings.Default["EstadoDia"];
            string estados = "";

            for (int i = 0; i < 36; i++)
            {
                estados += dia == 0 ? 'v' : 'f';
            }

            Settings.Default["EstadoDeMesas"] = estados;

            if (dia == 0)
            {
                funFunciones.VentaDCreate();
                Settings.Default["EstadoDia"] = funFunciones.UltimoIdForVenta();
            }
            else
            {
                funFunciones.CloseForDay();
                Settings.Default["EstadoDia"] = 0;
            }
            Settings.Default.Save();
            estadoBtnDia();
        }

        //funcion en mesas individuales
        private void AgregarProductoALaMesa(ProductosMesa newProducto)
        {
            if (MesaSelect.productos_vendidos == "" || MesaSelect.productos_vendidos == null)
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

        private void estadoBtnDia()
        {
            int dia = (int)Settings.Default["EstadoDia"];

            if (dia != 0)
            {
                btnAccionesDeMesas.Text = "Cerrar Dia";
                btnAccionesDeMesas.BackColor = Color.FromArgb(255, 0, 0);
                return;
            }
            btnAccionesDeMesas.Text = "Abrir Dia";
            btnAccionesDeMesas.BackColor = Color.FromArgb(0, 255, 0);
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
            estadoBtnDia();
            listarProductos();
            VerMesas();
        }

        private void CartelDeEstado()
        {
            string estados = (string)Settings.Default["EstadoDeMesas"];
            int numero = MesaSelect.id;

            if (numero == null || numero == 0) return;

            if (estados[numero - 1] == 'f')
            {
                btn_Agregar.Enabled = false;
                Label_Estado.Text = "Inhabilitado";
                Label_Estado.ForeColor = Color.Red;
                btnCerrarVenta.Enabled = false;
                btnCerrarVenta.BackColor = Color.Gray;
                btnTicket.Enabled = true;
                btnTicket.BackColor = Color.Green;
                btnLimpiarVenta.Enabled = true;
                btnLimpiarVenta.BackColor = Color.Red;
                btn_Agregar.Enabled = false;
                btn_Agregar.BackColor = Color.Gray;
                DataCompra.Enabled = false;
            }
            else
            {
                btn_Agregar.Enabled = true;
                Label_Estado.Text = "Habilitado";
                Label_Estado.ForeColor = Color.Green;
                btnCerrarVenta.Enabled = true;
                btnCerrarVenta.BackColor = Color.Red;
                btnTicket.Enabled = false;
                btnTicket.BackColor = Color.Gray;
                btnLimpiarVenta.Enabled = false;
                btnLimpiarVenta.BackColor = Color.Gray;
                btn_Agregar.Enabled = true;
                btn_Agregar.BackColor = Color.Green;
                DataCompra.Enabled = true;
            }
        }

        private void modificarEstadoMesa(int accion)
        {
            //cartel
            CartelDeEstado();

            //guardar cambios
            bool estadofun = funFunciones.MesasEdita(MesaSelect.id, MesaSelect);
            if (!estadofun) MessageBox.Show("Error a la Hora de Cerrar");
        
            if(accion == 2)
            {
                DataCompra.DataSource = null;
                MesaSelect.nombre = "";
                MesaSelect.productos_vendidos = "";
            }
        }

        private void cerrarInterfaceActual()
        {
            
                panelMesaNum.Visible = false;
                this.ControlBox = true;
                bool respuesta = funFunciones.MesasEdita(MesaSelect.id, MesaSelect);
                if (!respuesta) return;
                
                MesaSelect = null;
                DataCompra.DataSource = null;
                return;
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

        private void AbrirInterface(int numero)
        {
            int dia = (int)Settings.Default["EstadoDia"];
            if (dia == 0)
            {
                MessageBox.Show("Esta accion es invalida ya que no esta el dia inicializado");
                return;
            }

            InterfaceMesas mesa = funFunciones.MesasGet(numero);
            MesaSelect = mesa;
            Label_N_mesa.Text = "Mesa N°" + numero;
            panelMesaNum.Visible = true;
            asignarValoresDeMesas();
            CartelDeEstado();
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cerrarInterfaceActual();
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            AbrirInterface(1);
        }
        private void btnMesa2_Click(object sender, EventArgs e)
        {
            AbrirInterface(2);
        }
        private void btnMesa3_Click(object sender, EventArgs e)
        {
            AbrirInterface(3);
        }
        private void btnMesa4_Click(object sender, EventArgs e)
        {
            AbrirInterface(4);
        }
        private void btnMesa5_Click(object sender, EventArgs e)
        {
            AbrirInterface(5);
        }
        private void btnMesa6_Click(object sender, EventArgs e)
        {
            AbrirInterface(6);
        }
        private void btnMesa7_Click(object sender, EventArgs e)
        {
            AbrirInterface(7);
        }
        private void btnMesa8_Click(object sender, EventArgs e)
        {
            AbrirInterface(8);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AbrirInterface(9);
        }
        private void btnMesa10_Click(object sender, EventArgs e)
        {
            AbrirInterface(10);
        }
        private void btnMesa11_Click(object sender, EventArgs e)
        {
            AbrirInterface(11);
        }
        private void btnMesa12_Click(object sender, EventArgs e)
        {
            AbrirInterface(12);
        }
        private void btnMesa13_Click(object sender, EventArgs e)
        {
            AbrirInterface(13);
        }
        private void btnMesa14_Click(object sender, EventArgs e)
        {
            AbrirInterface(14);
        }
        private void btnMesa15_Click(object sender, EventArgs e)
        {
            AbrirInterface(15);
        }
        private void btnMesa16_Click(object sender, EventArgs e)
        {
            AbrirInterface(16);
        }
        private void btnMesa17_Click(object sender, EventArgs e)
        {
            AbrirInterface(17);
        }
        private void btnMesa18_Click(object sender, EventArgs e)
        {
            AbrirInterface(18);
        }
        private void btnMesa19_Click(object sender, EventArgs e)
        {
            AbrirInterface(19);
        }
        private void btnMesa20_Click(object sender, EventArgs e)
        {
            AbrirInterface(20);
        }
        private void btnMesa21_Click(object sender, EventArgs e)
        {
            AbrirInterface(21);
        }
        private void btnMesa22_Click(object sender, EventArgs e)
        {
            AbrirInterface(22);
        }
        private void btnMesa23_Click(object sender, EventArgs e)
        {
            AbrirInterface(23);
        }
        private void btnMesa24_Click(object sender, EventArgs e)
        {
            AbrirInterface(24);
        }
        private void btnMesa25_Click(object sender, EventArgs e)
        {
            AbrirInterface(25);
        }
        private void btnMesa26_Click(object sender, EventArgs e)
        {
            AbrirInterface(26);
        }
        private void btnMesa27_Click(object sender, EventArgs e)
        {
            AbrirInterface(27);
        }
        private void btnMesa28_Click(object sender, EventArgs e)
        {
            AbrirInterface(28);
        }
        private void btnMesa29_Click(object sender, EventArgs e)
        {
            AbrirInterface(29);
        }
        private void btnMesa30_Click(object sender, EventArgs e)
        {
            AbrirInterface(30);
        }
        private void btnMesa31_Click(object sender, EventArgs e)
        {
            AbrirInterface(31);
        }
       void btnMesa32_Click(object sender, EventArgs e)
        {
            AbrirInterface(32);
        }
       void btnMesa33_Click(object sender, EventArgs e)
        {
            AbrirInterface(33);
        }
       void btnMesa34_Click(object sender, EventArgs e)
        {
            AbrirInterface(34);
        }
       void btnMesa35_Click(object sender, EventArgs e)
        {
            AbrirInterface(35);
        }
       void btnMesa36_Click(object sender, EventArgs e)
        {
            AbrirInterface(36);
        }
       void panelMesaNum_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccionesDeMesas_Click(object sender, EventArgs e)
        {
            int dia = (int)Settings.Default["EstadoDia"];
            string message = dia != 0 ? "Estas Seguro de que quieres Cerrar el dia?" : "Estas Seguro de que quieres Abrir el dia?";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ActicionesDeDia();
            }
        }

        private void labNombre_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cerrar venta
            int dia = (int)Settings.Default["EstadoDia"];

            if (dia == 0) {
                MessageBox.Show("Accion inhabilidata");
                return;
            }

            string estados = (string)Settings.Default["EstadoDeMesas"];
            string newEstados = "";

            for(int i = 0; i < estados.Length; i++)
            {
                if (i == MesaSelect.id - 1 || estados[i] == 'f') newEstados += "f";
                else newEstados += "v";
            }

            //pasar numero
            CartelDeEstado();

            Settings.Default["EstadoDeMesas"] = newEstados;
            Settings.Default.Save();
            modificarEstadoMesa(1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar algun valor numerico en la casilla cantidad");
                return;
            }

            if (textBoxCantidad.Text == null) { 
                MessageBox.Show("Debe ingresar solo numero");
                return;
            }

            int cantidad = Convert.ToInt32(textBoxCantidad.Text);

            if(cantidad < 1)
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

            if (DataProductos.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Asigancion Erronea");
                return;
            }

            newProducto.id = Convert.ToInt32(DataProductos.SelectedRows[0].Cells[0].Value);
            newProducto.cantidad = Convert.ToInt32(textBoxCantidad.Text);

            textBoxCantidad.Text = "1";


            AgregarProductoALaMesa(newProducto);
            txtBoxBuscador.Focus();
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
                if(mesa.Visible) newString += "0";
            }

            Settings.Default["VistasMesas"] = newString;
            Settings.Default.Save();
        }

        private void DataCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlertaBorrado();
        }

        private void DataCompra_KeyDown(object sender, KeyEventArgs e)
        {
            AlertaBorrado();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarVenta_Click(object sender, EventArgs e)
        {
            int dia = (int)Settings.Default["EstadoDia"];

            if (dia == 0)
            {
                MessageBox.Show("Accion inhabilidata");
                return;
            }

            //aca lo que vamos hacer es limpiar y agregar una mesa de forma individual
            funFunciones.CleanForIndividualTable(MesaSelect.id);

            string estados = (string)Settings.Default["EstadoDeMesas"];
            string newEstados = "";

            for (int i = 0; i < estados.Length; i++)
            {
                if (i == MesaSelect.id - 1 || estados[i] != 'f') newEstados += "v";
                else newEstados += "f";
            }

            Settings.Default["EstadoDeMesas"] = newEstados;
            Settings.Default.Save();
            modificarEstadoMesa(2);
        }

        private void DataCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label_nombre_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DataProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void DataProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Indica que el evento ya fue manejado y no se debe realizar la función por defecto
                textBoxCantidad.Focus();
            }
        }
    }
}
