// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bucles While
            int counter = 0;
            int number = 5;

            while (counter < number)
            {
                Console.WriteLine("Counter N°: " + counter);
                counter++;
            }

            // // Bucles Do While
            String nombre_1 = "Nicolás";
            String nombre_2 = "Mario";

            do
            {
                Console.WriteLine("Son iguales");
            } while (nombre_1 == nombre_2);

            // Bucles For
            Console.WriteLine("Introduce un Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("El número es: " + i);
            }
        }
    }
}
