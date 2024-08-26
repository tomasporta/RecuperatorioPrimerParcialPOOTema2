using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Entidades03
{
    public  class Metro
    {
        private float longitud;

        // Constructor 
        public Metro(float longitud = 5)
        {
            this.longitud = longitud;
        }

        
        public float ObtenerLongitud()
        {
            return longitud;
        }

        
        public static implicit operator Metro(float valor)
        {
            return new Metro(valor);
        }

       
        public static explicit operator Yarda(Metro metro)
        {
            return new Yarda(metro.longitud * 1.09361f);
        }

        
        public static bool operator ==(Metro m1, Metro m2)
        {
            return Math.Abs(m1.longitud - m2.longitud) < 0.0001f;
        }

        public static bool operator !=(Metro m1, Metro m2)
        {
            return !(m1 == m2);
        }

       
        public static Metro operator +(Metro m, Yarda y)
        {
            return new Metro(m.longitud + ((Metro)y).longitud);
        }

        
        public override bool Equals(object obj)
        {
            if (obj is Metro)
            {
                return this == (Metro)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return longitud.GetHashCode();
        }
    }
}
