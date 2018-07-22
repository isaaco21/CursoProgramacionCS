using System;

namespace Tarea_2_Ejercicio_7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Escriba el monto a retirar: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = 0;
            int Num6 = 0;
            int Num7 = 0;
            if (Num1 % 100 != 0)
            {
                Console.WriteLine("Este monto es incompatible.");
            }
            else
            {

                while (Num1 >= 1000)
                {
                    Num1 = Num1 - 1000;
                    Num2 = Num2 + 1;
                }
                while (Num1 >= 500)
                {
                    Num1 = Num1 - 500;
                    Num6 = Num6 + 1;
                }
                while (Num1 >= 100)
                {
                    Num1 = Num1 - 100;
                    Num7 = Num7 + 1;
                }
                Console.WriteLine("Seran suministrados: ");
                Console.WriteLine(Num2 + " billetes de mil.");
                Console.WriteLine(Num6 + " billetes de quinientos.");
                Console.WriteLine(Num7 + " billetes de cien.");

            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
