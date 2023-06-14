using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_2___Unidad_3
{
    internal class Pieza
    {
        public int Largo;
        public int Ancho;
        public int Alto;

        public int setLargo(int largo)
        {
            Largo = largo;
            return Largo;
        }

        public int getLargo()
        {
            return Largo;
        }

        public int setAncho(int ancho)
        {
            Ancho = ancho; 
            return Ancho;
        }

        public int getAncho()
        {
            return Ancho;
        }

        public int setAlto(int alto)
        {
            Alto = alto;
            return Alto;
        }

        public int getAlto()
        {
            return Alto;
        }





    }
}
