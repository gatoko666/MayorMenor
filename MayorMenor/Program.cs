using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escribir un método que acepte una lista de números y devuelva una lista con los mismos números o
//rdenados de menor a mayor. Ejemplo: Si ingresamos la lista {5,2,9,4}, entonces el método debe devolver la lista {2,4,5,9}

namespace MayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de números de su lista :  ");
            int numero = int.Parse(Console.ReadLine());

            // Crear vector con tamaño que se ha asignado
            string[] soyUnVector = new string[numero];

            //llenarlo

            for (int i = 0; i < numero; i++)
            {
                Console.Write("Números  {0}: ", i);
                soyUnVector[i] = Console.ReadLine();
            }
            

            //imprimir
            /*
            Console.WriteLine(" \nValores del vector:\n");
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Posicion {0}: {1}", i, soyUnVector[i]);
            }
            */

            ///////////////////////////////////////////



            //se ordena de menor a mayor

            Array.Sort(soyUnVector);
            //se invierte el array

            Array.Reverse(soyUnVector);

            Console.WriteLine("\narreglo ordenado de mayor a menor:\n");
            //se imprime en pantalla el arreglo con un ciclo for
            for (int i = 0; i < soyUnVector.Length; i++)
            {
                Console.WriteLine("Posicion {0}: {1}", i, soyUnVector[i]);
            }



            Console.ReadKey();


        }
    }
}
