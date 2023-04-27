using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBar
{
    public class VentasDiarias
    {
        public int id { get; set; }
        public string fecha { get; set; }
        public float total { get; set; }
        public string productos { get; set; }
        
        //public VentasDiarias(int Id ,string Fecha ,float Total ,string Productos ,int TotalProductos)
        //{
        //    id = Id;
        //    fecha = Fecha;
        //    total = Total;
        //    productos = Productos;
        //    totalProductos = TotalProductos;
        //}
    }
}
