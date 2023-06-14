using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Telefono t1 = new Telefono("iPhone 8", "Apple");

            t1.setCodOp(1);

            Console.WriteLine("El código es: " + t1.getCodOp());

            Console.WriteLine("La marca es: " + t1.Marca);

            Console.WriteLine("El modelo es: " + t1.Modelo);


            t1.Llamar();

            Console.WriteLine(t1.Llamar());


            Console.WriteLine("Llamando a " + t1.Llamar("Lambi"));


            t1.setNumTelefonico("1152746629");

            Console.WriteLine("El nro telefónico es: " + t1.getNumTelefonico());







            Console.ReadKey();

        }
    }
}
