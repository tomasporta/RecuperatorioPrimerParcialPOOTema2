using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Entidades04
{
    public class RepositorioNumeros
    {
        private int cantidad;  
        private NumeroDivCincoSiete[] numeros;  

        // Propiedad para informar la cantidad
        public int Cantidad => cantidad;

        // Constructor que inicializa la cantidad y el array
        public RepositorioNumeros(int cantidad)
        {
            this.cantidad = cantidad > 0 ? cantidad : 5; 
            numeros = new NumeroDivCincoSiete[this.cantidad];
        }

        // Constructor 
        public RepositorioNumeros() : this(5) { }

       
        private bool EstaCompleto()
        {
            foreach (var num in numeros)
            {
                if (num == null)
                {
                    return false;
                }
            }
            return true;
        }

        private bool EstaVacio()
        {
            foreach (var num in numeros)
            {
                if (num != null)
                {
                    return false;
                }
            }
            return true;
        }

        // Método privado para verificar si un numero ya existe en el repositorio
        private bool Existe(NumeroDivCincoSiete numero)
        {
            foreach (var num in numeros)
            {
                if (num == numero)
                {
                    return true;
                }
            }
            return false;
        }

       
        public (bool, string) AgregarNumero(NumeroDivCincoSiete numero)
        {
            if (numero == null)
            {
                return (false, "El número no puede ser nulo.");
            }

            if (EstaCompleto())
            {
                return (false, "El repositorio está completo.");
            }

            if (Existe(numero))
            {
                return (false, "El número ya existe en el repositorio.");
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == null)
                {
                    numeros[i] = numero;
                    return (true, "Número agregado exitosamente.");
                }
            }

            return (false, "No se pudo agregar el número.");
        }

       
        public (bool, string) QuitarNumero(NumeroDivCincoSiete numero)
        {
            if (numero == null)
            {
                return (false, "El número no puede ser nulo.");
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                {
                    numeros[i] = null;
                    return (true, "Número eliminado exitosamente.");
                }
            }

            return (false, "El número no se encontró en el repositorio.");
        }

        public NumeroDivCincoSiete ObtenerElemento(int indice)
        {
            if (indice < 0 || indice >= numeros.Length)
            {
                throw new IndexOutOfRangeException("Índice fuera de rango.");
            }
            return numeros[indice];
        }

       
        public string ListarNumeros()
        {
            if (EstaVacio())
            {
                return "No hay elementos almacenados todavía.";
            }

            StringBuilder resultado = new StringBuilder();
            for (int i = 0; i < numeros.Length; i++)
            {
                resultado.AppendLine(numeros[i]?.ToString() ?? "Elemento Nulo");
            }

            return resultado.ToString();
        }

        public (bool, int) BuscarNumero(NumeroDivCincoSiete numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                {
                    return (true, i);
                }
            }
            return (false, -1);
        }

     
        public static implicit operator int(RepositorioNumeros repositorio)
        {
            int suma = 0;
            foreach (var numero in repositorio.numeros)
            {
                if (numero != null)
                {
                    suma += numero.Valor;
                }
            }
            return suma;
        }
    }
}
