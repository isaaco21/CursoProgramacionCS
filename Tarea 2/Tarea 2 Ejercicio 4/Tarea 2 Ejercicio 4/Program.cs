using System;


namespace Tarea_2_Ejercicio_4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Escriba su sueldo redondeado: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            double Num3 = Num1 * 0.0287;
            double Num4 = Num1 * 0.0304;
            double Num5 = 0;
            Console.WriteLine("Sueldo bruto: " + Num1);
            if (Num1 * 12 < 416220)
            {
                Console.WriteLine("ISR: Exento");
            }
            else if (Num1 * 12 < 624329)
            {
                Num5 = (Num1 - (416220.01 / 12)) * 0.15;
                Console.WriteLine("ISR: " + Num5);
            }
            else if (Num1 * 12 < 867123)
            {
                Num5 = (Num1 - (624329 / 12)) * 0.2;
                Console.WriteLine("ISR: " + Num5);
            }
            else
            {
                Num5 = (Num1 - (867123.01 / 12)) * 0.15;
                Console.WriteLine("ISR: " + Num5);
            }

            Console.WriteLine("SFS: " + Num4);
            Console.WriteLine("AFP: " + Num3);
            Console.WriteLine("Sueldo neto: " + (Num1 - Num3 - Num4 - Num5));
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
