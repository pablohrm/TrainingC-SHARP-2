using System;
using System.Collections.Generic;
using System.Text;

namespace ParImpar.Entities
{
    class Par
    {
        public int Pares { get; set; }

        public Par(int pares)
        {
            Pares = pares;
        }

        public override string ToString()
        {
            return ($"Estes são os numeros pares: {Pares}");
        }
    }
}
