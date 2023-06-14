using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_2___Unidad_3
{
    internal class Cama : Pieza
    {
        public int Largo;
        public string MarcaColchon;
        public string MarcaAlmohada;

        public int setLargoC(int largo)
        {
            Largo = largo;
            return Largo;
        }

        public int getLargoC() { return Largo; }

        public string setMarcaColchon(string marca)
        { 
            MarcaColchon = marca; 
            return MarcaColchon;
        }

        public string getMarcaColchon() { return MarcaColchon; }

        public string setMarcaAlmohada(string marcaA)
        {
            MarcaAlmohada = marcaA;
            return MarcaAlmohada;
        }

        public string getMarcaAlmohada() { return MarcaAlmohada; }






    }
}
