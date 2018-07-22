using System;

namespace Tarea_1_Practica_11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio 11: ");
            Console.Write("Escriba el numero a procesar: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = 0;
            Console.WriteLine("Esta es la tabla del " + Num1);
            while (Num2 < 12)
            {
                Num2 = Num2 + 1;
                Console.WriteLine(Num1 + "X" + Num2 + "=" + Num1 * Num2);
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
