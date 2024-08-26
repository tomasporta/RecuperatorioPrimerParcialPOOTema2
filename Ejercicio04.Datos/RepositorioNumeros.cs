﻿using Ejercicio04.Entidades;
using System.Text;

namespace Ejercicio04.Datos
{
    public class RepositorioNumeros
    {
        private int cantidad;
        private NumeroDivCincoSiete?[] numeros;

        public RepositorioNumeros(int cantidad)
        {
            this.cantidad = cantidad;
            numeros = new NumeroDivCincoSiete[cantidad];
        }
        public RepositorioNumeros() : this(5)
        {

        }
        public int GetCantidad()
        {
            return cantidad;
        }

        private bool EstaCompleto() => numeros.All(x => x is not null);
        private bool Existe(NumeroDivCincoSiete n) => numeros.Contains(n);
        private bool EstaVacio() => numeros.All(x => x is null);
        public bool ValidarNumero(NumeroDivCincoSiete numero)
        {
            return numero.EsValido();

        }
        public (bool, string) AgregarNumero(NumeroDivCincoSiete numero)
        {
            if (!EstaCompleto())
            {
                if (ValidarNumero(numero))
                {
                    if (!Existe(numero))
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (numeros[i] is null)
                            {
                                numeros[i] = numero;
                                return (true, $"{numero} fue agregado en la posición {i}");
                            }
                        }

                    }
                    return (false, "Elemento duplicado!!");

                }
                return (false, "Número no válido!!");

            }
            return (false, "Array completo!!");
        }

        public (bool, string) QuitarNumero(NumeroDivCincoSiete numero)
        {
            if (!EstaVacio())
            {
                if (ValidarNumero(numero))
                {
                    if (Existe(numero))
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (numeros[i]?.GetValor() == numero.GetValor())
                            {
                                numeros[i] = null;
                                return (true, $"{numero} quitado de la posición {i}");
                            }
                        }

                    }
                    return (false, "Número no se encuentra en el repositorio!!!");
                }
                return (false, "Número perfecto no válido!!!");
            }
            return (false, "Repositorio vacío!!!");
        }
        public NumeroDivCincoSiete? AccederElemento(int indice)
        {
            if (indice < 0 || indice >= cantidad || numeros[indice] is null)
            {
                throw new IndexOutOfRangeException("Índice fuera de rango o número no encontrado.");
            }

            return numeros[indice];
        }

        public string MostrarNumeros()
        {
            StringBuilder sb = new StringBuilder();
            if (!EstaVacio())
            {
                foreach (var numero in numeros)
                {
                    if (numero is not null)
                    {
                        sb.AppendLine(numero.ToString());
                    }
                    else
                    {
                        sb.AppendLine("Elemento Nulo");
                    }
                }
            }
            else
            {
                sb.AppendLine("No hay elementos almacenados todavía");
            }
            return sb.ToString();
        }


        public (bool, int) BuscarNumero(NumeroDivCincoSiete numero)
        {
            int indice = -1;
            for (int i = 0; i < cantidad; i++)
            {
                if (numeros[i]?.GetValor() == numero.GetValor())
                {
                    indice = i;
                    return (true, indice);
                }
            }
            return (false, indice);
        }


        public static implicit operator int(RepositorioNumeros repo)
        {
            int suma = 0;
            foreach (var numero in repo.numeros)
            {
                if (numero is not null)
                {
                    suma += numero.GetValor();
                }
            }

            return suma;
        }
    }
}

