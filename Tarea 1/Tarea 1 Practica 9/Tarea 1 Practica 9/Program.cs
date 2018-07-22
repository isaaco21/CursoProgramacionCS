using System;

namespace Tarea_1_Practica_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio 7: ");
            Console.Write("Escriba el numero a procesar: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            while (Num1 > 0)
            {
                if (Num1 % 2 == 0)
                {
                    Console.WriteLine("El numero " + Num1 + " es par");
                    Num1 = Num1 - 1;
                }
                else
                {
                    Console.WriteLine("El numero " + Num1 + " es impar");
                    Num1 = Num1 - 1;
                }
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
