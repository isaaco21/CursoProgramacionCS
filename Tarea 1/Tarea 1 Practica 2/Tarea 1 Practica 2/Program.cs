using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_Practica_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio 2: ");
            Console.Write("Escriba un numero: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = Num1 % 2;


            if (Num2 == 0)
            {
                Console.WriteLine("Este numero es par");
            }
            else
                Console.WriteLine("Este numero es impar");
            {
                
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
