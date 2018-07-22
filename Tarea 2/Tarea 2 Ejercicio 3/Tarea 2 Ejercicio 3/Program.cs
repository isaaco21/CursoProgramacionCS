using System;

namespace Tarea_2_Ejercicio_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ejercicio 3: Introduzca un numero ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca otro numero");
            Num1 = Num1 * Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba un tercero: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 == Num2)
            {
                Console.WriteLine(Num1 + " es igual a " + Num2);
            }
            else
            {
                Console.WriteLine(Num1 + " no es igual a " + Num2);
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
