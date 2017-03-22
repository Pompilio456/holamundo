using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Animal
    {
        string nombre;
        int patas;
        Boolean cola;
        Boolean pico;
        public Animal(string nombre,int patas,Boolean cola,Boolean pico)
        {
            this.nombre = nombre;
            this.patas = patas;
            this.cola = cola;
            this.pico = pico;
        }

        public string VerNombre =>
            "El animal es un " + nombre;

    }
}
