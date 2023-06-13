using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: Edad, Sueldo, Nombre

            //estoy creando una clase de "Persona", con un objeto persona.
            Persona p1 = new Persona("Juan"); //p1 es una variable del tipo Persona
            p1.setEdad(20);//así le estoy asignando un valor a la edad de esa persona
            Console.WriteLine(p1.saludar("Jose"));//comportamiento de la persona (método)
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());
            Console.ReadKey();

            //estoy creando una clase botella con un objeto 
            Botella b1 = new Botella("Rojo", "Plástico");//new= invoca al constructor de la clase. Al hacer esto, genera en un banco de memoria el objeto
            //El constructores una función especial, que lo que hace es generar el objeto de manera inicial
            //b1.Capacidad = 200;//así le estoy asignando un valor a la capacidad de la botella

            Botella b2 = new Botella();//constructor botella vacío. En línea 23, constructor botella con valores

            int algo = b1.Capacidad;//esto lee el valor de la capacidad y lo guarda en la variable "algo"

            Console.WriteLine("Capacidad botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantActual);

        }
    }
}
