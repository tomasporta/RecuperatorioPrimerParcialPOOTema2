using Ejercicio02.Entidades;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un ISBN para validar:");
            string isbn = Console.ReadLine();

            if (ValidadorISBN.Validar(isbn))
            {
                Console.WriteLine("El ISBN es válido.");
            }
            else
            {
                Console.WriteLine("El ISBN no es válido.");
            }
        }
    }
}
