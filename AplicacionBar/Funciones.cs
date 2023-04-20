using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //public InterfaceMesas MesasGet(int id)
        //{
        //}

        //public bool MesasEdita(int id, InterfaceMesas newClass)
        //{
        //}

        //VentasDiarias diarias
        //public List<VentasDiarias> VentaDGetAll()
        //{
        //}

        //public VentasDiarias VentaDGet(int id)
        //{
        //}

        //public bool VentaDCreate(VentasDiarias newClass)
        //{
        //}

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
