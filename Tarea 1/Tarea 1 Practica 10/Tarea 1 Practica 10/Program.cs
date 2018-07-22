using System;


namespace Tarea_1_Practica_10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio 10: ");
            Console.Write("Escriba el numero a sumar, escriba 0 para parar: ");
            int Num1 = 0;
            int Num2 = 0;
            int Num3 = 1;
            while (Num3 != 0)
            {
                if (Num2 == 0)
                {
                    Num3 = Convert.ToInt32(Console.ReadLine());
                    Num1 = Num1 + Num3;
                    Num2 = Num2 + 1;
                    Console.WriteLine("Has introducido el numero: " + Num1);
                }
                else
                {
                    Num3 = Convert.ToInt32(Console.ReadLine());
                    Num1 = Num1 + Num3;
                    Num2 = Num2 + 1;
                    Console.WriteLine("Has introducido " + Num2 + " numeros y su suma es " + Num1);
                }
            }
            Console.Clear();
            Console.WriteLine("Se ha introducido el cero, se han introducido "+(Num2-1)+" numeros y su suma es "+Num1);
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
