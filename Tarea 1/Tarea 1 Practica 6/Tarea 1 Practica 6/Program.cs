using System;

namespace Tarea_1_Practica_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio 6: ");
            Console.Write("Escriba el primer numero a multiplicar: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el segundo numero a multiplicar: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int Num3 = Num1 * Num2;
            Console.WriteLine("El resultado es: " + Num3);
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
