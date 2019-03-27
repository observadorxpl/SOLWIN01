using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Clases;
namespace POO.Clases
{
    class Exec
    {
        public static void Main(string[] args)
        {
            Articulo a = new Articulo();
            a.Codigo = 100;
            a.Nombre = "Monitor LG 15.6' ";
            a.PrecioSoles = 249;
            a.Categoria = "Tecnologia";
            a.UnidadMedida = "Soles";
            Console.WriteLine("a.NombreProducto()");
        }
    }
}
