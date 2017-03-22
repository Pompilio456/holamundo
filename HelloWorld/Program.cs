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
            Console.WriteLine("Hola mundo");

            Persona extraño1 = new Persona("Yilber",21,"2557001");
            string datos = extraño1.DatosPersona();
            Console.WriteLine(datos);

            Console.WriteLine("Chao mundo");

            Console.ReadKey();
        }
    }
}
