using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Clear();
        Write("Ingrese el nombre de la profesión (Ingeniero/Medico/Abogado):");
        string? nombre = ReadLine();

        Write("Ingrese el área:");
        string? area = ReadLine();

        Profesion p;
        switch (nombre!.ToLower())
        {
            case "ingeniero":
                Write("Ingrese el sector:");
                string? sector = ReadLine();
                p = new Ingeniero(nombre, area!, sector!);
                break;
            case "medico":
                Write("Ingrese la especialidad:");
                string? especialidad = ReadLine();
                p = new Medico(nombre, area!, especialidad!);
                break;
            case "abogado":
                Write("Ingrese la rama:");
                string? rama = ReadLine();
                p = new Abogado(nombre, area!, rama!);
                break;
            default:
                Write("Profesión no válida.");
                return;
        }
        if (p!=null)
            WriteLine(p.Descripcion());
        WriteLine("Entre cualquier tecla");
        ReadKey();
    }
}