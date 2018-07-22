using System;

namespace Tarea_2_Ejercicio_5
{
    class Program
    {
        static void Main()
        {
            int Num1 = 0;
            string usn = "usn";
            string pass = "pass";
            while (Num1 < 3)
            {
                Console.Write("Escriba el nombre de usuario: ");
                string usn1 = Console.ReadLine();
                Console.Write("Escriba la contraseña: ");
                string pass1 = Console.ReadLine();
                if (usn + pass != usn1 + pass1)
                {
                    Console.WriteLine("Nombre de usuario o contraseña incorrectos, intentelo de nuevo.");
                    Console.WriteLine("");
                    Num1 = Num1 + 1;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Credenciales correctas.");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                }

            }
            Console.WriteLine("Numero de intentos superados, favor contactar administrador");
            
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
