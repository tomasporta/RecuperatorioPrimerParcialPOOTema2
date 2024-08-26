namespace Ejercicio04.Entidades
{
    public class NumeroDivCincoSiete
    {
        private int valor;

        public NumeroDivCincoSiete(int valor)
        {
            this.valor = valor;
        }
        public int GetValor() => valor;
        public bool EsValido()
        {
            return valor % 5 == 0 && valor % 7 == 0;
        }

        public override string ToString()
        {
            return $"{valor}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is NumeroDivCincoSiete np)) return false;
            return valor == np.valor;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                return hash += 23 * valor.GetHashCode();
            }
        }
        public static bool operator ==(NumeroDivCincoSiete a, NumeroDivCincoSiete b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(NumeroDivCincoSiete a, NumeroDivCincoSiete b)
        {
            return !(a == b);
        }

    }

}
