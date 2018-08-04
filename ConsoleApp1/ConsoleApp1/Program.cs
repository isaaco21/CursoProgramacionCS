using System;

namespace ConsoleApp1
{
    class Program
    {
        static Double JuanD = 200000.00;
        static Double pabloS = 175896.45;
        static Double FranciscoM = 999999.99;

        static void Main()
        {
            MostrarEstado();
            cerrar();

            Console.WriteLine("Que tipo de transaccion desea hacer? pulse 0 para salir.");
            Console.WriteLine("Pulse 1 para deposito.");
            Console.WriteLine("Pulse 2 para retiro.");
            Console.WriteLine("Pulse 3 para transferencias.");
            int indice = int.Parse(Console.ReadLine());


            switch (indice)
            {
                case 0:
                    Console.WriteLine("Adios!");
                    cerrar();
                    break;
            }


        }
        static void MostrarEstado()
        {
            Console.WriteLine("1. Juan Duarte cuenta con " + JuanD + " pesos");
            Console.WriteLine("2. Pablo Sanchez cuenta con " + pabloS + " pesos");
            Console.WriteLine("3. Francisco Mella cuenta con " + FranciscoM + " pesos");
        }
        static void cerrar()
        {
            Console.ReadKey();
            Console.Clear();
        }


        }
    }

