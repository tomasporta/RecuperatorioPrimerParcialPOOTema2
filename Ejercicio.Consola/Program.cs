using Ejercicio.Entidades;
using RecuperatorioPrimerParcialPOOTema2.Shared;

namespace Ejercicio.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Radio = ConsoleExtensions.ReadInt("ingresar el valor del radio");
            int Altura = ConsoleExtensions.ReadInt("ingresar el valor de  la  altura");

            Cilindro cilindro = new Cilindro(2, 5);


            cilindro.InformarDatos();
        }
    }
}            

