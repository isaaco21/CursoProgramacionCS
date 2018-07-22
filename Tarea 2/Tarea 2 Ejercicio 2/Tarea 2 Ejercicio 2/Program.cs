using System;

namespace Tarea_2_Ejercicio_2
{
    class Program
    {
        static void Main()
        {
            int[] Array1 = new int[3];
            for (int Num1 = 0; Num1 < 3; Num1++)
            {
                Console.Write("Ingrese un numero: ");
                Array1[Num1] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(Array1);
            Console.WriteLine("\nLos números ordenados son:");

            for (int Num1 = 0; Num1 < 3; Num1++)
            {
                Console.Write(Array1[Num1] + ", ");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
