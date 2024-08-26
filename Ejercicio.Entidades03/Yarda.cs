using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Entidades03
{
    public class Yarda
    {
       
        private float longitud;

        // Constructor 
        public Yarda(float longitud = 5)
        {
            this.longitud = longitud;
        }

        // Método para informar la longitud
        public float ObtenerLongitud()
        {
            return longitud;
        }

        
        public static implicit operator Yarda(float valor)
        {
            return new Yarda(valor);
        }

       
        public static explicit operator Metro(Yarda yarda)
        {
            return new Metro(yarda.longitud * 0.9144f);
        }

        ///// Sobrecarga del operador de igualdad 
        public static bool operator ==(Yarda y1, Yarda y2)
        {
            return Math.Abs(y1.longitud - y2.longitud) < 0.0001f;
        }

        
        public static bool operator !=(Yarda y1, Yarda y2)
        {
            return !(y1 == y2);
        }

        // Sobrecarga del operador de suma para sumar una Yarda y un Metro
        public static Yarda operator +(Yarda y, Metro m)
        {
            return new Yarda(y.longitud + ((Yarda)m).longitud);
        }

        // Override de Equals y GetHashCode para evitar warnings
        public override bool Equals(object obj)
        {
            if (obj is Yarda)
            {
                return this == (Yarda)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return longitud.GetHashCode();
        }
    }
}
