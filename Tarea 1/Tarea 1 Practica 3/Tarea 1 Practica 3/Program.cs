using System;

namespace Tarea_1_Practica_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio 3: ");
            Console.Write("Escriba su edad: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            if (Num1 < 13)
            {
                Console.WriteLine("El usuario es niño");
            }
            else if (Num1 < 18)
            {
                Console.WriteLine("El usuario es adolescente");
            }
            else
            {
                Console.WriteLine("El usuario es un adulto");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
