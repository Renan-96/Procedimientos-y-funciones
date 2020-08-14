    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite al usuario el ingreso de una palabra, deberá mostrar la palabra reemplazando las
            //vocales con el numero 0 ejemplo: Claudio Resultado Cl00d00

            string nombre = "";

            Console.WriteLine("Ingrese una palabra");
            nombre = Console.ReadLine();                    
            Console.WriteLine(convertir(nombre));

            Console.ReadLine();
        }

        static string convertir(string nombre)
        {
            nombre = nombre.Replace("a", "0").Replace("e", "0").Replace("i", "0").Replace("o", "0").Replace("u", "0");
            nombre = nombre.Replace("A", "0").Replace("E", "0").Replace("I", "0").Replace("O", "0").Replace("U", "0");

            return nombre;
        }
    }
}
