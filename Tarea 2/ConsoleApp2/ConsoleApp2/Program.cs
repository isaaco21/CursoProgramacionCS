using System;

class Program
{
    static void Main(){
        int[] Array1;
        int Num1 = 0;
        int Num2 = 0;
        int Num6 = 0;
        int Num7 = 0;
        Double Num3 = 0;
        Double Num4 = 0;
        Double Num5 = 0;
        String usn = "Usuario";
        String pass = "Pass";
        String usn1 = "" ;
        String pass1 = "";

        Console.Write("Escriba el numero de tarea a revisar: ");
        int Indice = Convert.ToInt32(Console.ReadLine());
        switch (Indice)
            {
                case 1:
                Console.Write("Escriba un numero y le dire a que mes pertenece: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                    switch (Num1)
                    {
                    case 1:
                        Console.WriteLine("Enero");
                        break;
                    case 2:
                        Console.WriteLine("Febrero");
                        break;
                    case 3:
                        Console.WriteLine("Marzo");
                        break;
                    case 4:
                        Console.WriteLine("Abril");
                        break;
                    case 5:
                        Console.WriteLine("Mayo");
                        break;
                    case 6:
                        Console.WriteLine("Junio");
                        break;
                    case 7:
                        Console.WriteLine("Julio");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Septiembre");
                        break;
                    case 10:
                        Console.WriteLine("Octubre");
                        break;
                    case 11:
                        Console.WriteLine("Noviembre");
                        break;
                    case 12:
                        Console.WriteLine("Diciembre");
                        break;
                    default:
                        Console.WriteLine("Invalido");
                        break;

                }
                break;
            case 2:
                Array1 = new int[3];
                for (Num1 = 0; Num1 < 3; Num1++)
                {
                    Console.Write("Ingrese un numero: ");
                    Array1[Num1] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(Array1);
                Console.WriteLine("\nLos números ordenados son:");

                for (Num1 = 0; Num1 < 3; Num1++)
                {
                    Console.Write(Array1[Num1]+", ");
                }
                break;
            case 3:
                Console.Write("Ejercicio 3: Introduzca un numero ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduzca otro numero");
                Num1 = Num1 * Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba un tercero: ");
                Num2 = Convert.ToInt32(Console.ReadLine());
                if (Num1 == Num2) {
                    Console.WriteLine(Num1+" es igual a "+Num2);
                }
                else
                {
                    Console.WriteLine(Num1 + " no es igual a " + Num2);
                }
                break;
            case 4:
                Console.Write("Escriba su sueldo redondeado: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Num3 = Num1 * 0.0287;
                Num4 = Num1 * 0.0304;

                Console.WriteLine("Sueldo bruto: " + Num1);
                if (Num1 * 12 < 416220) {
                    Console.WriteLine("ISR: Exento");
                }
                else if(Num1 * 12 < 624329) {
                    Num5 = (Num1 - (416220.01/12))*0.15;
                    Console.WriteLine("ISR: "+Num5);
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

                Console.WriteLine("SFS: "+ Num4);
                Console.WriteLine("AFP: "+Num3);
                Console.WriteLine("Sueldo neto: "+(Num1-Num3-Num4-Num5));
                break;
            case 5:
                while (Num1 < 3) {
                    Console.Write("Escriba el nombre de usuario: ");
                    usn1 = Console.ReadLine();
                    Console.Write("Escriba la contraseña: ");
                    pass1 = Console.ReadLine();
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
                break;
            case 6:
                Console.Write("Introduzca un numero: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Num6 = 1;
                do
                {
                    Num2 = 1;
                    do
                    {
                        Num7 = (Num6 * Num2);
                        Console.WriteLine(Num6 +" x "+ Num2+" = "+Num7);
                        Num2 = Num2 + 1;
                    } while (Num2 <= 12);
                    Console.WriteLine();
                    Num6 = Num6 + 1;
                } while (Num6 <= Num1);

                break;
            case 7:
                Console.Write("Escriba el monto a retirar: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine(Num2+" billetes de mil.");
                    Console.WriteLine(Num6+" billetes de quinientos.");
                    Console.WriteLine(Num7+" billetes de cien.");

                }

                break;

        }
        Console.ReadKey();
        Console.Clear();
        Main();
    }

}
