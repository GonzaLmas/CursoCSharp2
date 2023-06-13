using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            nombre = "Hola cómo estas? " + nombre;

            int cant = nombre.Length;//devuelve la cantidad de caracteres

            nombre = nombre.ToUpper();//pasa todo a mayúsculas
            
            nombre = nombre.ToLower();//pasa todo a minúsculas

            nombre = nombre.Replace('a', 'e');//todos los caracteres a los reemplza por la e




        }
    }
}
