using AplicacionBar.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionBar
{
    public class Funciones
    {
        DataBase objectDatabase = new DataBase();

        //classiicaciones
        public List<Clasificacion> ClassGetAll()
        {
            return objectDatabase.ClassGetAll();
        }

        public Clasificacion ClassGet(int id)
        {
            return objectDatabase.ClassGet(id);
        }

        public bool ClassCreate(Clasificacion newClass)
        {
            return objectDatabase.ClassCreate(newClass);
        }

        public bool ClassEdita(int id, Clasificacion newClass)
        {
            return objectDatabase.ClassEdita(id , newClass);
        }

        public bool ClassRemove(int id)
        {
            return objectDatabase.ClassRemove(id);
        }

        //productos
        public List<InterfaceProductos> ProductGetAll()
        {
            return objectDatabase.ProductGetAll();
        }

        public InterfaceProductos ProductGet(int id)
        {
            return objectDatabase.ProductGet(id);
        }

        public bool ProductCreate(InterfaceProductos newProducto)
        {
            return objectDatabase.ProductCreate(newProducto);
        }

        public bool ProductEdita(int id, InterfaceProductos newClass)
        {
            return objectDatabase.ProductEdita(id , newClass);
        }

        public bool ProductRemove(int id)
        {
            return objectDatabase.ProductRemove(id);
        }

        //mesas
        public InterfaceMesas MesasGet(int id)
        {
            return objectDatabase.MesasGet(id);
        }

        public bool MesasEdita(int id, InterfaceMesas newClass)
        {
            return objectDatabase.MesasEdita(id , newClass);
        }

        //VentasDiarias diarias
        public List<VentasDiarias> VentaDGetAll()
        {
            return objectDatabase.VentaDGetAll();
        }

        public VentasDiarias VentaDGet(int id)
        {
            return objectDatabase.VentaDGet(id);
        }

        public bool VentaDCreate()
        {
            return objectDatabase.VentaDCreate();
        }

        public bool VentaDEdita(int id , VentasDiarias newVenta)
        {
            return objectDatabase.VentaDEdita(id , newVenta);
        }

        public int UltimoIdForVenta()
        {
            List<VentasDiarias> newList =  objectDatabase.VentaDGetAll();
            if (newList.Count == 0) return 0;
            return newList[newList.Count - 1].id;
        }

        public bool CleanForIndividualTable(int id)
        {
            InterfaceMesas mesa = objectDatabase.MesasGet(id);

            if (mesa.productos_vendidos == "") return false;
            VentasDiarias VentaDay =  objectDatabase.VentaDGet(UltimoIdForVenta());
            List<ProductosMesa> ProductosDay = new List<ProductosMesa>();
            List<ProductosMesa> Productos = JsonConvert.DeserializeObject<List<ProductosMesa>>(mesa.productos_vendidos);

            if (VentaDay.productos == null || VentaDay.productos == "")
            {
                 ProductosDay = JsonConvert.DeserializeObject<List<ProductosMesa>>("[]");
            }
            else
            {
                 ProductosDay = JsonConvert.DeserializeObject<List<ProductosMesa>>(VentaDay.productos);
            }

            if (ProductosDay == null) return false;

            foreach (ProductosMesa Producto in Productos)
            {
                bool condicional = false;
                foreach (ProductosMesa ProductoDay in ProductosDay)
                {
                    if (ProductoDay.id == Producto.id)
                    {
                        ProductoDay.cantidad += Producto.cantidad;
                        condicional = true;
                        break;
                    }
                }
                if (!condicional) ProductosDay.Add(Producto);
            }

            float total = 0;
            
            foreach (ProductosMesa ProductoDay in ProductosDay)
            {
                InterfaceProductos prod = objectDatabase.ProductGet(ProductoDay.id);
                if(prod != null) total += (ProductoDay.cantidad * prod.precio);
            }

            VentaDay.total = total;
            VentaDay.productos = JsonConvert.SerializeObject(ProductosDay);
            objectDatabase.VentaDEdita(VentaDay.id, VentaDay);

            mesa.productos_vendidos = "";
            mesa.nombre = "";
            objectDatabase.MesasEdita(mesa.id, mesa);

            return true;
        }

        public void CloseForDay()
        {
            string CantidadDeMesas = (string)Settings.Default["VistasMesas"];

            for(int i = 0; i < CantidadDeMesas.Length; i++)
            {
                bool respuesta = CleanForIndividualTable(i + 1);
            }

            return;
        }

        public int IdForNameClass(string name)
        {
            List<Clasificacion> clasificaciones = objectDatabase.ClassGetAll();

            if (clasificaciones == null || clasificaciones.Count() == 0) return 0;

            foreach (Clasificacion clasificacione in clasificaciones)
            {
                if (clasificacione.nombre == name) return clasificacione.id;
            }

            return 0;
        }

        public bool NoRepeatName(string name)
        {
            List<InterfaceProductos> Productos = objectDatabase.ProductGetAll();

            if (Productos.Count() == 0) return true;

            if (Productos == null || Productos.Count() == 0) return false;

            foreach (InterfaceProductos Producto in Productos)
            {
                if (Producto.nombre == name) return false;
            }

            return true;
        }

        public bool NoRepeatClass(string name)
        {
            List<Clasificacion> clasificaciones = objectDatabase.ClassGetAll();

            if (clasificaciones.Count() == 0) return true;

            if (clasificaciones == null || clasificaciones.Count() == 0) return false;

            foreach (Clasificacion clasificacion in clasificaciones)
            {
                if (clasificacion.nombre == name) return false;
            }

            return true;
        }

        public string ClassForId(int id)
        {
            Clasificacion clasificacion = objectDatabase.ClassGet(id);

            if (clasificacion == null) return null;

            return clasificacion.nombre;
        }
    }
}
