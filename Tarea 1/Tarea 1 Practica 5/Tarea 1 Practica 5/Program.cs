using System;

namespace Tarea_1_Practica_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio 5: ");
            Console.Write("Primer Numero: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo Numero: ");
            Num1 = Num1 + Convert.ToInt32(Console.ReadLine());
            Console.Write("Tercer Numero: ");
            Num1 = Num1 + Convert.ToInt32(Console.ReadLine());
            Console.Write("Cuarto Numero: ");
            Num1 = Num1 + Convert.ToInt32(Console.ReadLine());
            Console.Write("quinto Numero: ");
            Num1 = Num1 + Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma de los numeros dados es: " + Num1);
            Console.Write("El promedio de los numeros dados es: ");
            Num1 = Num1 / 5;
            Console.WriteLine(Num1);
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
