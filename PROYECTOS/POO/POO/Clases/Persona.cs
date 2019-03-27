using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Persona
    {
        //Definicion de propiedades
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public bool Sexo { get; set; }

        public int Edad { get; set; }

        public decimal peso { get; set; }
        // Definicion de constructores

        public Persona()
        {
        }
        public Persona(string nombre, string apellidos, string email) {
            this.Nombre = nombre;
            this.Apellidos = Apellidos;
            this.Email = email;
        }
        public Persona(string nombre, string apellidos, 
            DateTime fechanacimiento, int edad)
        {
            this.Nombre = nombre;
            this.Apellidos = Apellidos;
            this.FechaNacimiento = fechanacimiento;
            this.Edad = edad;
        }
        //Definicion de metodos
        public virtual string ListarNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public string ObtenerGenero() {
            if (this.Sexo == true)
            {
                return "Masculino";
            }
            else
            {
                return "Femenino";
            }
        }
        public void Limpiar() {
            this.Nombre = "";
            this.Apellidos = "";
            this.FechaNacimiento = DateTime.Now; // Fecha Actual
            this.Email = "";
            this.Sexo = false;
            this.Edad = 0;
            this.peso = 0;
        }
    }
}
