using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Articulo: Producto
    {
        public string Categoria;
        public string UnidadMedida;

        public Articulo()
        {
        }
        public Articulo(int codigo, string nombre, decimal preciosoles,
            string categoria, string unidadmedida)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.PrecioSoles = preciosoles;
            this.Categoria = categoria;
            this.UnidadMedida = unidadmedida;
        }
        public decimal PrecioEuros(decimal x) {
            return this.PrecioSoles * x;
        }
        public override string NombreProducto()
        {
            return this.Nombre.ToLower();
        }
    }

  
}

