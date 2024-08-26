using Ejercicio.Entidades04;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           RepositorioNumeros repositorio = new RepositorioNumeros();
            bool salir = false;

            while (!salir)
            {
                
                Console.WriteLine("\nMenú de Opciones:");
                Console.WriteLine("1. Agregar Número Perfecto");
                Console.WriteLine("2. Quitar Número Perfecto");
                Console.WriteLine("3. Listar Números Perfectos");
                Console.WriteLine("4. Buscar Número Perfecto");
                Console.WriteLine("5. Sumar Números Perfectos en el Repositorio");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingrese el número perfecto a agregar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorAgregar))
                        {
                            NumeroDivCincoSiete numero = new NumeroDivCincoSiete(valorAgregar);
                            var resultado = repositorio.AgregarNumero(numero);
                            Console.WriteLine(resultado.Item2);
                        }
                        else
                      {
                           Console.WriteLine("Valor inválido.");
                       }
                      break;

                   case "2":
                       Console.Write("Ingrese el número perfecto a quitar: ");
                       if (int.TryParse(Console.ReadLine(), out int valorQuitar))
                       {
                          NumeroDivCincoSiete numero = new NumeroDivCincoSiete(valorQuitar);
                           var resultado = repositorio.QuitarNumero(numero);
                           Console.WriteLine(resultado.Item2);
                       }
                      else
                       {
                          Console.WriteLine("Valor inválido.");
                      }
                      break;

                    case "3":
                        Console.WriteLine("\nNúmeros Perfectos en el Repositorio:");
                        Console.WriteLine(repositorio.ListarNumeros());
                        break;

                    case "4":
                        Console.Write("Ingrese el número perfecto a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorBuscar))
                        {
                            NumeroDivCincoSiete numero = new NumeroDivCincoSiete(valorBuscar);
                            var resultado = repositorio.BuscarNumero(numero);
                            if (resultado.Item1)
                        {
                               Console.WriteLine($"Número encontrado en la posición {resultado.Item2}");
                          }
                            else
                            {
                                Console.WriteLine("Número no encontrado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case "5":
                        int suma = repositorio;
                    Console.WriteLine($"La suma de los números perfectos es: {suma}");
                        break;

                    case "6":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
