using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Producto
    {
        public int Codigo;
        public string Nombre;
        public decimal PrecioSoles;

        public Producto()
        {
        }
        public Producto(int codigo, string nombre, decimal preciosoles)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.PrecioSoles = preciosoles;
        }

        public decimal PrecioDolares(decimal x) {
            return this.PrecioSoles * x;
        }
        public virtual string NombreProducto() {
            return this.Nombre.ToUpper();
        }

    }
}
