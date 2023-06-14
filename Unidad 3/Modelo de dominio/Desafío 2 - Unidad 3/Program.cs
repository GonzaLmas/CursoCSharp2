using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_2___Unidad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pieza p1 = new Pieza();

            p1.setLargo (3);
            Console.WriteLine("El largo de la pieza es: " + p1.getLargo());

            p1.setAncho (2);
            Console.WriteLine("El ancho de la pieza es: " + p1.getAncho());

            p1.setAlto (3);
            Console.WriteLine("El alto de la pieza es: " + p1.getAlto());


            Cama c1 = new Cama ();  
            
            c1.setLargoC (2);
            Console.WriteLine("El largo de la cama es: " + c1.getLargoC());

            c1.setMarcaAlmohada ("Piero");
            Console.WriteLine("La marca de la almohada es: " + c1.getMarcaAlmohada());

            c1.setMarcaColchon("Canon");
            Console.WriteLine("La marca del colchón es: " + c1.getMarcaColchon());










































            Console.ReadKey();
        }
    }
}
