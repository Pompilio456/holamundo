using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world"); //atajo cw
            Persona extraño1 = new Persona("Yilber",21,"2557001");
            string datos = extraño1.DatosPersona();
            Console.WriteLine(datos);
            Console.WriteLine("Bye world");

            Console.WriteLine("Hola mundo");
            Persona extraño2 = new Persona("Sebastian", 21, "2557001");
            datos = extraño1.DatosPersona();
            Console.WriteLine(datos);
            Console.WriteLine("Chao mundo");

            Console.WriteLine("konichiwa");
            Persona extraño3 = new Persona("Pompilio", 21, "2557001");
            datos = extraño1.DatosPersona();
            Console.WriteLine(datos);
            Console.WriteLine("Sayonara");

            Animal perro = new Animal("Labrador",4,true,false);
            Console.WriteLine(perro.VerNombre);

            Console.ReadKey();
        }
    }
}
