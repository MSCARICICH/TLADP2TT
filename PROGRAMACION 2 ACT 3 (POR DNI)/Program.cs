using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream Archivo;
            StreamWriter Grabar;
            StreamReader Leer;
            DateTime FECHA;
            float SUELDO;
            int DNI;
            string cadena, scont, nombre, apell, dni, fecha, sueldo;
            char opcion;
            int menu = 0, cont;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t      | Base de datos by Martochx |\n", Console.ForegroundColor = ConsoleColor.Cyan);
                Console.WriteLine("\t=========================================", Console.ForegroundColor = ConsoleColor.Green);
                Console.WriteLine("\t| 1. Crear un nuevo registro            |", Console.ForegroundColor = ConsoleColor.Blue);
                Console.WriteLine("\t| 2. Buscar un registro existente       |", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.WriteLine("\t| 3. Borrar un registro                 |", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("\t| 4. Salir                              |", Console.ForegroundColor = ConsoleColor.White);
                Console.WriteLine("\t=========================================", Console.ForegroundColor = ConsoleColor.Green);
                opcion = Console.ReadKey().KeyChar;
                switch (opcion)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.Write("Numero de personas a registrar: ");
                            scont = Console.ReadLine();
                            if (int.TryParse(scont, out cont) != false)
                            {

                            }
                            else
                            {
                                Console.WriteLine("Caracteres no validos...");
                                break;
                            }
                                while (cont > 0)
                                {
                                    Console.Clear();
                                    Console.Write("Ingresar nombre: ");
                                    nombre = Console.ReadLine();
                                    Console.Clear();
                                    Console.Write("Ingresar apellido: ");
                                    apell = Console.ReadLine();
                                    Console.Clear();
                                    Console.Write("Ingresar DNI: ");
                                    dni = Console.ReadLine();
                                    if (int.TryParse(dni, out DNI) != false)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("Caracteres no validos :v.");
                                        break;
                                    }
                                    Console.Clear();
                                    Console.Write("Ingresar sueldo: ");
                                    sueldo = Console.ReadLine();
                                    if (float.TryParse(sueldo, out SUELDO) != false)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("Caracteres no validos :v.");
                                        break;
                                    }
                                    Console.Clear();
                                    Console.Write("Ingresar fecha: ");
                                    fecha = Console.ReadLine();
                                    if (DateTime.TryParse(fecha, out FECHA) != false)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("Caracteres no validos :v.");
                                        break;
                                    }
                                    Console.WriteLine("\n\nIngrese la primer linea a almacenar en un nuevo documento: ");
                                    Console.Write("\n--> ");
                                    cadena = Console.ReadLine();
                                    Archivo = new FileStream(dni + ".txt", FileMode.Create);
                                    Grabar = new StreamWriter(Archivo);
                                    Grabar.WriteLine($"\n\tNombre: {nombre}");
                                    Grabar.WriteLine($"\n\tApellido: {apell}");
                                    Grabar.WriteLine($"\n\tDNI: {DNI}");
                                    Grabar.WriteLine($"\n\tSueldo: {SUELDO} ARS");
                                    Grabar.WriteLine($"\n\tFecha: {FECHA}");
                                    Grabar.WriteLine("\n\tComentario: " + cadena + "\n\n");
                                    cont--;
                                    Grabar.Close();
                                    Archivo.Close();
                                }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case '2':
                    {
                        Console.Clear();
                        Console.Write("Ingresar DNI: ");
                        dni = Console.ReadLine();
                        Console.Clear();
                        if (File.Exists(dni + ".txt"))
                        {
                            Console.WriteLine("\n\tEl DNI ingresado esta asociado al siguiente registro: ", Console.ForegroundColor = ConsoleColor.Blue);
                            Console.WriteLine("\nContenido del archivo:", Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("=====================================================================================", Console.ForegroundColor = ConsoleColor.White);
                            Archivo = new FileStream(dni + ".txt", FileMode.Open, FileAccess.Read);
                            Leer = new StreamReader(Archivo);
                            while (Leer.EndOfStream == false)
                            {
                                cadena = Leer.ReadLine();
                                Console.WriteLine(cadena, Console.ForegroundColor = ConsoleColor.White);
                            }
                            Console.WriteLine("=====================================================================================", Console.ForegroundColor = ConsoleColor.White);
                            Leer.Close();
                            Archivo.Close();
                        }
                        else
                        {
                            Console.WriteLine("\n\tEl archivo no existe.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case '3':
                    {
                        Console.Clear();
                        Console.Write("Ingrese Documento: ");
                        dni = Console.ReadLine();
                        File.Delete($"D:/Martochx System/C (Lenguaje de programación)/PROGRAMACION 2/PROGRAMACION 2 ACT 3 (POR DNI)/PROGRAMACION 2 ACT 3 (POR DNI)/bin/Debug/{dni + ".txt"}");
                        Console.Clear();
                        Console.WriteLine("\n\tEl Registro se ha eliminado correctamente...", Console.ForegroundColor = ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;
                    }
                case '4':
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tFinalizando el programa...");
                        menu = 1;
                        Console.ReadKey();
                        break;
                    }
                }
            } while (menu != 1);
        }
    }
}


