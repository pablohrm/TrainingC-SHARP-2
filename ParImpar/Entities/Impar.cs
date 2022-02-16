using System;
using System.Collections.Generic;
using System.Text;

namespace ParImpar.Entities
{
    class Impar
    {
        public int Impares { get; set; }

        public Impar(int impares)
        {
            Impares = impares;
        }

        public override string ToString()
        {
            return ($"Estes são os numeros impares: {Impares}");
        }
    }
}
