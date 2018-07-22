using System;

namespace Tarea_1_Practica_7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio 7: ");
            Console.Write("Escriba el dividendo: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el divisor: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            while (Num2 == 0)
            {
                Console.Write("Escriba un divisor valido: ");
                Num2 = Convert.ToInt32(Console.ReadLine());
            }
            int Num3 = Num1 / Num2;
            Console.Write("El resultado es: " + Num3);

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
