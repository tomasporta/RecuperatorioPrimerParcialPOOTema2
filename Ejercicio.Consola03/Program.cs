using Ejercicio.Entidades03;
using System.Diagnostics.Metrics;

namespace Ejercicio.Consola03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Metro m1 = new Metro(1);
            Yarda y1 = new Yarda(1);

            
            Metro m2 = 2; //// Implicita de float a Metro
            Yarda y2 = (Yarda)m1; //// Explicita de Metro a Yarda

            // Muestro los  valores iniciales y  las conversiones
            Console.WriteLine($"Metro 1: {m1.ObtenerLongitud()} metros");
            Console.WriteLine($"Yarda 1: {y1.ObtenerLongitud()} yardas");
            Console.WriteLine($"Metro 2 (implicita): {m2.ObtenerLongitud()} metros");
            Console.WriteLine($"Yarda 2 (de Metro a Yarda): {y2.ObtenerLongitud()} yardas");

            
            Console.WriteLine($"¿Metro 1 == Metro 2? : {m1 == m2}");
            Console.WriteLine($"¿Yarda 1 == Yarda 2? : {y1 == y2}");

            
            Metro sumaMetros = m1 + y1;
            Yarda sumaYardas = y1 + m1;
            Console.WriteLine($"Suma en metros (m1 + y1): {sumaMetros.ObtenerLongitud()} metros");
            Console.WriteLine($"Suma en yardas (y1 + m1): {sumaYardas.ObtenerLongitud()} yardas");
        }
    }
    }

