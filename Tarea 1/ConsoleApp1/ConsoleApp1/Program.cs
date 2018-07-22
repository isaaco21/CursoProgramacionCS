using System;
    class Program
    {

        public static void Main()
        {
        Console.WriteLine("Escriba el numero de tarea o escriba 'Salir' para cerrar.");
        String caseSwitch = Console.ReadLine();
        int Num1 = 0;
        int Num2 = 0;
        int Num3 = 0;
        switch (caseSwitch)
        {
            case "1":
                Num1 = 50;
                Num2 = 51;
                Num3 = Num1 * Num2;
                Console.WriteLine("Ejercicio 1: ");
                    Console.WriteLine(Num3);
                Console.ReadKey();
                Console.Clear();
                Main();
            break;

            case "2":
                Console.WriteLine("Ejercicio 2: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Num2 = Num1 % 2;


                    if (Num2 == 0)
                    {
                        Console.WriteLine("Este numero es par");
                    }
                    else
                        Console.WriteLine("Este numero es impar");
                    {
                    caseSwitch = "2";
                }
                Console.ReadKey();
                Console.Clear();
                Main();
            break;

            case "3":
                Console.WriteLine("Ejercicio 3: ");
                Console.Write("Escriba su edad: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                    if (Num1 < 13){
                        Console.WriteLine("El usuario es niño");
                    }
                    else if (Num1 < 18 ){
                        Console.WriteLine("El usuario es adolescente");
                    }
                    else{
                    Console.WriteLine("El usuario es un adulto");
                }
                Console.ReadKey();
                Console.Clear();
                Main();
            break;
            case "4":
                Console.WriteLine("Ejercicio 4: ");
                Num1 = 23;
                Num2 = 24;
                Num3 = 25;
                Console.WriteLine(Num1 + Num2 + Num3);
                Console.ReadKey();
                Console.Clear();
                Main();
            break;
            case "5":
                Console.WriteLine("Ejercicio 5: ");
                Console.Write("Primer Numero: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Segundo Numero: ");
                Num1 = Num1 + Convert.ToInt32(Console.ReadLine());
                Console.Write("Tercer Numero: ");
                Num1 = Num1 + Convert.ToInt32(Console.ReadLine());
                Console.Write("Cuarto Numero: ");
                Num1 = Num1 + Convert.ToInt32(Console.ReadLine());
                Console.Write("quinto Numero: ");
                Num1 =Num1 + Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("La suma de los numeros dados es: " + Num1);
                Console.Write("El promedio de los numeros dados es: ");
                Num1 = Num1 / 5;
                Console.WriteLine(Num1);
                Console.ReadKey();
                Console.Clear();
                Main();
                break;
            case "6":
                Console.WriteLine("Ejercicio 6: ");
                Console.Write("Escriba el primer numero a multiplicar: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba el segundo numero a multiplicar: ");
                Num2 = Convert.ToInt32(Console.ReadLine());
                Num3 = Num1 * Num2;
                Console.WriteLine("El resultado es: " + Num3);
                Console.ReadKey();
                Console.Clear();
                Main();
            break;

            case "7":
                Console.WriteLine("Ejercicio 7: ");
                Console.Write("Escriba el dividendo: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba el divisor: ");
                Num2 = Convert.ToInt32(Console.ReadLine());
                while (Num2 == 0)
                {
                    Console.Write("Escriba un divisor valido: ");
                    Num2 = Convert.ToInt32(Console.ReadLine());
                }
                Num3 = Num1 / Num2;
                Console.Write("El resultado es: " + Num3);

                Console.ReadKey();
                Console.Clear();
                Main();
                break;

            case "8":
                Console.WriteLine("Ejercicio 7: ");
                Console.Write("Escriba el dividendo: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba el divisor: ");
                Num2 = Convert.ToInt32(Console.ReadLine());
                while (Num2 == 0)
                {
                    Console.Write("Escriba un divisor valido: ");
                    Num2 = Convert.ToInt32(Console.ReadLine());
                }
                Num3 = Num1 % Num2;
                Console.Write("El resultado es: " + Num3);

                Console.ReadKey();
                Console.Clear();
                Main();
            break;

            case "9":
                Console.WriteLine("Ejercicio 7: ");
                Console.Write("Escriba el numero a procesar: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                while (Num1 > 0) {
                    if(Num1 % 2 == 0){
                        Console.WriteLine("El numero "+Num1+" es par");
                        Num1 = Num1 - 1;
                    }
                    else
                    {
                        Console.WriteLine("El numero "+Num1+" es impar");
                        Num1 = Num1 - 1;
                    }
                }
                Console.ReadKey();
                Console.Clear();
                Main();
            break;
            case "10":
                Console.WriteLine("Ejercicio 10: ");
                Console.Write("Escriba el numero a sumar, escriba 0 para parar: ");
                Num1 = 0;
                Num2 = 0;
                Num3 = 1;
                while (Num3 != 0)
                {
                    if(Num2 == 0) {
                        Num3 = Convert.ToInt32(Console.ReadLine());
                        Num1 = Num1 + Num3;
                        Num2 = Num2 + 1;
                        Console.WriteLine("Has introducido el numero: "+Num1);
                    }
                    else{
                        Num3 = Convert.ToInt32(Console.ReadLine());
                        Num1 = Num1 + Num3;
                        Num2 = Num2 + 1;
                        Console.WriteLine("Has introducido "+Num2+" numeros y su suma es "+Num1);
                    }
                }
                Console.Clear();
                Console.WriteLine("Se ha introducido el cero, se han introducido "+(Num2-1)+" numeros y su suma es "+Num1);
                Console.WriteLine("Se ha introducido el cero");
                Console.ReadKey();
                Console.Clear();
                Main();
            break;

            case "11":
                Console.WriteLine("Ejercicio 11: ");
                Console.Write("Escriba el numero a procesar: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Num2 = 0;
                Console.WriteLine("Esta es la tabla del "+Num1);
                while (Num2 < 12)
                {
                    Num2 = Num2 + 1;
                    Console.WriteLine(Num1+"X"+Num2+"="+Num1 * Num2);
                }
                Console.ReadKey();
                Console.Clear();
                Main();

                break;

            case "Salir":
                Console.WriteLine("Adios");
                Console.ReadKey();
            break;
            default:
                Console.WriteLine("Opcion incorrecta, presione enter para volver a intentar.");
                Console.ReadKey();
                Console.Clear();
                Main();
            break;

        }

    }
    }
