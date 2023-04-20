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
    public partial class Formularios : Form
    {
        int actividad;
        Funciones funFunciones = new Funciones();
        InterfaceProductos generalProducto = new InterfaceProductos();
        Clasificacion generalClasificacion = new Clasificacion();

        private bool cargaDeClases()
        {
            List<Clasificacion> clases = funFunciones.ClassGetAll();

            if (clases == null) return false;

            foreach(Clasificacion clase in clases)
            {
                cmbBoxClass.Items.Add(clase.nombre);
            }

            return true;
        }

        public Formularios(int action , int id = 0)
        {
            actividad = action;
            InitializeComponent();

            //action = 0 -> crear producto
            //action = 1 -> editar producto
            //action = 2 -> crear clase
            //action = 3 -> editar clase
            if(action == 0 || action == 1) cargaDeClases();
            if(action == 1 || action == 3)
            {
                btn_funcion.Text = "Actualizar";
                btn_funcion.BackColor = Color.Blue;
                btn_eliminar.Visible = true;

                if(action == 1)
                {
                    InterfaceProductos productosSelect = funFunciones.ProductGet(id);
                    generalProducto = productosSelect;

                    textBox_nombre.Text = productosSelect.nombre;
                    cmbBoxClass.Text = funFunciones.ClassForId(productosSelect.clasificacion);
                    textBox_precio.Text = productosSelect.precio.ToString();
                }
                else
                {
                    Clasificacion clasSelect = funFunciones.ClassGet(id);
                    generalClasificacion = clasSelect;
                }
            }
            if (action == 2 || action == 3)
            {
                label_clas.Visible = false;
                label_precio.Visible = false;
                textBox_precio.Visible = false;
                cmbBoxClass.Visible = false;
            }
        }

        private void clean()
        {
            textBox_nombre.Text = "";
            textBox_precio.Text = "";
            cmbBoxClass.Text = "";
        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_funcion_Click(object sender, EventArgs e)
        {
            //Productos crear
            if (actividad == 0)
            {
                if (textBox_nombre.Text == "" || textBox_precio.Text == "" || cmbBoxClass.Text == "")
                {
                    MessageBox.Show("Falta completar todos los campo");
                    return;
                }

                InterfaceProductos newProducto = new InterfaceProductos();

                newProducto.nombre = textBox_nombre.Text;
                newProducto.clasificacion = funFunciones.IdForNameClass(cmbBoxClass.Text);
                newProducto.precio = Convert.ToInt32(textBox_precio.Text);

                bool respuesta2 = funFunciones.NoRepeatName(newProducto.nombre);
                if (!respuesta2) 
                { 
                    MessageBox.Show("Nombre repetido, no valido");
                    return;                
                }

                bool respuesta1 = funFunciones.ProductCreate(newProducto);
                if (respuesta1) { 
                    MessageBox.Show("Creado con Exito");
                    clean();
                } 
                else MessageBox.Show("Error al Crear");
            }
            //clase crear
            else if (actividad == 2)
            {
                //"error data"
                if (textBox_nombre.Text == "")
                {
                    MessageBox.Show("Falta completar todos los campo");
                    return;
                }

                Clasificacion newClass = new Clasificacion();

                newClass.nombre = textBox_nombre.Text;

                bool respuesta1 = funFunciones.NoRepeatClass(newClass.nombre);

                if (!respuesta1)
                {
                    MessageBox.Show("Nombre Repetido");
                    return;
                }

                bool respuesta = funFunciones.ClassCreate(newClass);

                if (respuesta)
                {
                    MessageBox.Show("Creado con Exito");
                    clean();
                }
                else MessageBox.Show("Error al Crear");
            }
            //Productos editar
            else if (actividad == 1)
            {
                if (textBox_nombre.Text == "" || textBox_precio.Text == "" || cmbBoxClass.Text == "")
                {
                    MessageBox.Show("Falta completar todos los campo");
                    return;
                }

                InterfaceProductos newProducto = new InterfaceProductos();

                newProducto.nombre = textBox_nombre.Text;
                newProducto.clasificacion = funFunciones.IdForNameClass(cmbBoxClass.Text);
                newProducto.precio = Convert.ToInt32(textBox_precio.Text);

                bool respuesta2 = funFunciones.NoRepeatName(newProducto.nombre);
                if (!respuesta2 && generalProducto.nombre != newProducto.nombre) 
                {
                    MessageBox.Show("Nombre repetido, no valido");
                    return;
                } 

                bool respuesta1 = funFunciones.ProductEdita(generalProducto.id , newProducto);
                if (respuesta1)
                {
                    MessageBox.Show("Editado con Exito");
                    this.Close();
                }
                else MessageBox.Show("Error al Editadar");
            }
            //clase editar
            else if (actividad == 3)
            {
                if (textBox_nombre.Text == "")
                {
                    MessageBox.Show("Falta completar todos los campo");
                    return;
                }

                Clasificacion newClass = new Clasificacion();

                newClass.nombre = textBox_nombre.Text;

                bool respuestaName = funFunciones.NoRepeatClass(newClass.nombre);
                if(!respuestaName)
                {
                    MessageBox.Show("Nombre Repetido");
                    return;
                }

                bool respuesta = funFunciones.ClassCreate(newClass);
                if (respuesta)
                {
                    MessageBox.Show("Creado con Exito");
                    this.Close();
                }
                else MessageBox.Show("Error al Crear");
            }
        }

        private void textBox_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(actividad == 1)
            {
                funFunciones.ProductRemove(generalProducto.id);
            }
            else
            {
                funFunciones.ClassRemove(generalClasificacion.id);
            }
            
            this.Close();
        }
    }
}
