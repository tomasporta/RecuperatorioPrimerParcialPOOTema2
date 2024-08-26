using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Entidades
{
    public  class Cilindro
    {
        // Atributo de solo lectura 
        public int Radio { get; }

       
        private double Diametro { get; }

       
        public int Altura { get; }

        // Constructor que inicializa los atributos y valida los datos
        public Cilindro(int radio, int altura)
        {
            if (radio <= 0)
            {
                throw new ArgumentException("El radio debe ser un número positivo.");
            }

            if (altura <= 0)
            {
                throw new ArgumentException("La altura debe ser un número positivo.");
            }

            Radio = radio;
            Altura = altura;
            Diametro = 2 * radio;
        }

        // Método para calcular el área del cilindro
        public double CalcularArea()
        {
            return 2 * Math.PI * Radio * (Radio + Altura);
        }

        // Método para calcular el volumen del cilindro
        public double CalcularVolumen()
        {
            return Math.PI * Math.Pow(Radio, 2) * Altura;
        }

        

        // Método para informar el valor del diámetro
        public double ObtenerDiametro()
        {
            return Diametro;
        }

        // Método para imprimir todos los datos del cilindro
        public void InformarDatos()
        {
            Console.WriteLine($"Diámetro: {Diametro}");
            Console.WriteLine($"Área: {CalcularArea():F5}");
            Console.WriteLine($"Volumen: {CalcularVolumen():F5}");
        }
    }
}
