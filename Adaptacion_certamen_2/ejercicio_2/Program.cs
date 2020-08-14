using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, limite = 0, numero = 0;
            int pares = 0, impares = 0, positivos = 0, negativos = 0, primos = 0, nprimos = 0;
            int sumaP = 0, sumaI = 0;

            try
            {
                Console.WriteLine("Ingrese la cantidad de numeros");
                limite = int.Parse(Console.ReadLine());

                while (limite != contador)
                {
                    contador++;
                    Console.WriteLine("ingrese un numero");
                    numero = int.Parse(Console.ReadLine());

                    if (numero % 2 == 0)
                    {
                        sumaP = numero + sumaP;
                        pares++;
                    }
                    else
                    {
                        sumaI = numero + sumaI;
                        impares++;
                    }
                    if (numero >= 0)
                    {
                        positivos++;
                    }
                    else
                    {
                        negativos++;
                    }
                    if (numero > 1)
                    {
                        if (numero == 2 || numero == 3)
                        {
                            primos++;
                        }
                        if (numero % 2 == 0)
                        {
                            nprimos++;
                        }
                        else
                        {
                            if (numero % 3 == 0)
                            {
                                nprimos++;
                            }
                            else
                            {
                                if (numero / 1 == numero)
                                {
                                    if (numero / numero == 1)
                                    {
                                        primos = primos + 1;
                                    }

                                }
                            }
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Los numeros pares son: " + pares);
                Console.WriteLine();
                Console.WriteLine("Los numeros impares son: " + impares);
                Console.WriteLine();
                Console.WriteLine("Los numeros positivos son: " + positivos);
                Console.WriteLine();
                Console.WriteLine("Los numeros negativos son: " + negativos);
                Console.WriteLine();
                Console.WriteLine("La suma de los numeros pares son: " + sumaP);
                Console.WriteLine();
                Console.WriteLine("La suma de los numeros impares son: " + sumaI);
                Console.WriteLine();
                Console.WriteLine("Los numeros primos son: " + primos);

            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Solo ingresar números por favor.");
                Console.WriteLine();
                Console.WriteLine("Error: " + e.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}
