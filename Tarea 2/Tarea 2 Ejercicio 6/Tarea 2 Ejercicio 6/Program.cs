using System;

namespace Tarea_2_Ejercicio_6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduzca un numero: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num6 = 1;
            do
            {
                int Num2 = 1;
                do
                {
                    int Num7 = (Num6 * Num2);
                    Console.WriteLine(Num6 + " x " + Num2 + " = " + Num7);
                    Num2 = Num2 + 1;
                } while (Num2 <= 12);
                Console.WriteLine();
                Num6 = Num6 + 1;
            } while (Num6 <= Num1);

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
