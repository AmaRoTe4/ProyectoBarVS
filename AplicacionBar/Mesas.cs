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
    public partial class Mesas : Form
    {
        List<Button> mesasList = new List<Button>();

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

        public Mesas()
        {
            InitializeComponent();
            AgregarMesas();
        }

        private void Mesas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            bool condicion = true;
            int id = -1;

            while (condicion && mesasList.Count - 1 > id)
            {
                id++;
                if(mesasList[id].Visible == false) condicion = false;
            }

            if (id != mesasList.Count) mesasList[id].Visible= true;
        }


        private void btnEliminarMesa_Click(object sender, EventArgs e)
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


        private void button8_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = false;
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa13_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa14_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa15_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa16_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa17_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa18_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa19_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa20_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa21_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa22_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa23_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa24_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa25_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa26_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa27_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa28_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa29_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa30_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa31_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa32_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa33_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa34_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa35_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
        }

        private void btnMesa36_Click(object sender, EventArgs e)
        {
            panelMesaNum.Visible = true;
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
    }
}

//int numero = Int32.Parse(menuMesas.Items[menuMesas.Items.Count - 1].Text);
//if (numero == null) menuMesas.Items.Add("0");
//menuMesas.Items.Add((numero + 1).ToString());
