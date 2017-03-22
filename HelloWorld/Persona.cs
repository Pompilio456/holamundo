using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Persona
    {
        string nombre;
        int edad;
        string telefono;
        public Persona(string nombre,int edad,string telefono)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.telefono = telefono;
        }

        public string DatosPersona()
        {
            return "La persona se llama " + nombre + " tiene " + edad + " años y la puede llamar al \r\n" + telefono;
        }


    }
}
