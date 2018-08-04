using System;

class AddressPrompt
{
    AddressBook book;

    public AddressPrompt()
    {
        book = new AddressBook();
    }

    static void Main(string[] args)
    {
        string selection = "";
        AddressPrompt prompt = new AddressPrompt();

        prompt.displayMenu();
        while (!selection.ToUpper().Equals("Q"))
        {
            Console.WriteLine("Selection: ");
            selection = Console.ReadLine();
            prompt.performAction(selection);
        }
    }

    void displayMenu()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("=========");
        Console.WriteLine("A - Add an Address");
        Console.WriteLine("D - Delete an Address");
        Console.WriteLine("E - Edit an Address");
        Console.WriteLine("L - List All Addresses");
        Console.WriteLine("Q - Quit");
    }

    void performAction(string selection)
    {
        string name = "";
        string phone = "";
        string mail = "";

        switch (selection.ToUpper())
        {
            case "A":
                Console.WriteLine("Introduzca nombre: ");
                name = Console.ReadLine();
                Console.WriteLine("Introduzca telefono: ");
                phone = Console.ReadLine();
                Console.WriteLine("Introduzca correo: ");
                mail = Console.ReadLine();
                if (book.add(name, phone, mail))
                {
                    Console.WriteLine("Datos añadidos exitosamente");
                }
                else
                {
                    Console.WriteLine("ya existe un registro para {0}.", name);
                }
                break;
            case "D":
                Console.WriteLine("Entre un nombre a borrar: ");
                name = Console.ReadLine();
                if (book.remove(name))
                {
                    Console.WriteLine("Se ha borrado el registro exitosamente");
                }
                else
                {
                    Console.WriteLine("No se pudo encontrar a {0}.", name);
                }
                break;
            case "L":
                if (book.isEmpty())
                {
                    Console.WriteLine("no hay entradas.");
                }
                else
                {
                    Console.WriteLine("Registros:");
                    book.list(
                      delegate (Address a) {
                          Console.WriteLine("{0} - {1} - {2}", a.name, a.address, a.mail);
                      }
                    );
                }
                break;
            case "E":
                Console.WriteLine("Enter Name to Edit: ");
                name = Console.ReadLine();
                Address addr = book.find(name);
                if (addr == null)
                {
                    Console.WriteLine("No se puede encontrar {0} en el registro.", name);
                }
                else
                {
                    Console.WriteLine("Entre la nueva informacion:");
                    Console.Write("");
                    addr.address = Console.ReadLine();
                    Console.WriteLine("se acaba de actualizar a {0}", name);
                }
                break;
        }
    }
}