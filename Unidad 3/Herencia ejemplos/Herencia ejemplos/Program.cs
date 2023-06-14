using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Apellido = ("Lamas");

            Developer d1 = new Developer();
            d1.Apellido = ("Fernandez");

            Tester t1 = new Tester();
            t1.Nombre = ("Gonzalo");

            Lider l1 = new Lider();
            l1.Apellido = ("Gomez");



        }
    }
}
