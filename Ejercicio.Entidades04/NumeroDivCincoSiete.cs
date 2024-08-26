using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Entidades04
{
    public class NumeroDivCincoSiete
    {
       
        public int Valor { get; set; }

        // Constructor para inicializar el valor
        public NumeroDivCincoSiete(int valor)
        {
            if (!EsDivisiblePorCincoYSiete(valor))
            {
                throw new ArgumentException("El número no es divisible por 5 y 7.");
            }
            Valor = valor;
        }

        // Método para validar si el número es divisible por 5 y 7
        private bool EsDivisiblePorCincoYSiete(int valor)
        {
            return valor % 5 == 0 && valor % 7 == 0;
        }

       
        public override string ToString()
        {
            return $"NumeroDivCincoSiete: {Valor}";
        }

  
        public override bool Equals(object obj)
        {
            if (obj is NumeroDivCincoSiete otroNumero)
            {
                return Valor == otroNumero.Valor;
            }
            return false;
        }

      
        public override int GetHashCode()
        {
            return Valor.GetHashCode();
        }

       
        public static bool operator ==(NumeroDivCincoSiete num1, NumeroDivCincoSiete num2)
        {
            if (ReferenceEquals(num1, null))
            {
                return ReferenceEquals(num2, null);
            }
            return num1.Equals(num2);
        }

        public static bool operator !=(NumeroDivCincoSiete num1, NumeroDivCincoSiete num2)
        {
            return !(num1 == num2);
        }
    }
}
