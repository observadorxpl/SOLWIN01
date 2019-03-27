using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Empleado: Persona
    {
        public string DNI { get; set; }
        public DateTime FechaContrato { get; set; }
        public Empleado()
        {
        }
        public Empleado(string nombre, string apellidos, DateTime fechacontrato, 
            String DNI)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaContrato = fechacontrato;
            this.DNI = DNI;
        }
        public int TiempoServicio()
        {
            //Restar fecha Actual(Año) - Fecha de Contrato(Año)
            return (DateTime.Now.Year - this.FechaContrato.Year);
        }
        public int TiempoServicio(int añoactual)
        {
            //Restar fecha Actual(Año) - Fecha de Contrato(Año)
            return (añoactual - this.FechaContrato.Year);
        }
        public int TiempoServicio(int añoactual, int añodecontrato)
        {
            //Restar fecha Actual(Año) - Fecha de Contrato(Año)
            return (añoactual - añodecontrato);
        }
        //Aplicar polimorfismo
        public override string ListarNombreCompleto()
        {
            return this.Apellidos + ", " + this.Nombre;
        }

    }
}
