using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadrilaterosPOO.Entidades
{
    public class Cuadrilateros
    {
        public int ladoA { get; set; }
        public int ladoB { get; set; }


        public int GetPerimetro()
        {
            return 2 * ladoA + ladoB;
        }

        public int GetArea()
        {
            return ladoA + ladoB;
        }

        public bool Validar()
        {
            return ladoA > 0 && ladoB > 0 && ladoA < ladoB;
        }


        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Cuadrilateros))
            {
                return false;
            }

            return this.ladoA == ((Cuadrilateros)obj).ladoA &&
                   this.ladoB == ((Cuadrilateros)obj).ladoB;
        }


        public override int GetHashCode()
        {
            return (ladoA + ladoB).GetHashCode();
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
