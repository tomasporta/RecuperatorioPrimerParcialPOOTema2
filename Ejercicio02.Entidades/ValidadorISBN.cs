using System.Text.RegularExpressions;

namespace Ejercicio02.Entidades
{
    public static class ValidadorISBN
    {
        public static bool Validar(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn))
            {
                return false;
            }

            // Limpiar el ISBN removiendo los guiones
            string cleanIsbn = isbn.Replace("-", "");

            // Verificar el formato y calcular el dígito verificador
            if (EsISBN10(cleanIsbn))
            {
                return VerificarISBN10(cleanIsbn);
            }
            else if (EsISBN13(cleanIsbn))
            {
                return VerificarISBN13(cleanIsbn);
            }

            return false;
        }

        private static bool EsISBN10(string isbn)
        {
            return isbn.Length == 10 && Regex.IsMatch(isbn, @"^\d{9}[\dX]$");
        }

        private static bool EsISBN13(string isbn)
        {
            return isbn.Length == 13 && Regex.IsMatch(isbn, @"^\d{13}$");
        }

        private static bool VerificarISBN10(string isbn)
        {
            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                suma += (i + 1) * (isbn[i] - '0');
            }

            char ultimoCaracter = isbn[9];
            int digitoVerificador = ultimoCaracter == 'X' ? 10 : ultimoCaracter - '0';

            return (suma % 11) == digitoVerificador;
        }

        private static bool VerificarISBN13(string isbn)
        {
            int suma = 0;

            for (int i = 0; i < 12; i++)
            {
                int digito = isbn[i] - '0';
                suma += (i % 2 == 0) ? digito : digito * 3;
            }

            int digitoVerificador = 10 - (suma % 10);
            if (digitoVerificador == 10)
            {
                digitoVerificador = 0;
            }

            return digitoVerificador == (isbn[12] - '0');
        }
    }
}
