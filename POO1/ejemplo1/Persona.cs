using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Las funciones dentro de una clase se llaman "método"
        //Persona: Edad, Sueldo, Nombre

        /*ATRIBUTOS o MIEMBREOS: variables que nos
        van a permitir guardar los datos de esa persona*/
        
        /*ATRIBUTOS: tienen que cumplir ciertas características, especialmente 
        el ENCAPSULAMIENTO. Encapsulamiento: un atributo de una clase NO tendría
        que ser accedido desde el exterior directamente. Estos atributos deben 
        estar ocultos al exterior. Para acceder, hay que usar mecanismos.*/
        
        /*MODIFICADORES DE VISIBILIDAD: palabras reservadas que nos permiten
        calificar un atributo y/o una función y/o una clase también. Los más 
        comunes son "private" y "public"*/

        private int edad;
        private float sueldo;
        private string nombre;

        //MECANISMO
        public void setEdad(int e)//función para escribir un valor
        { 
            edad = e;
        }

        //Leo la edad de esa persona
        public int getEdad()//función para obtener el valor
        { 
            return edad; 
        }

        public Persona(string nombre)//constructor para ingresar UNA SOLA vez el nombre
        {
            this.nombre = nombre;   
        }

        //MÉTODOS: acciones, ej: personas: caminar, saludar, etc

        public string saludar()
        {
            return "Hola soy " + nombre;
        }

        //sobrecarga de Método
        public string saludar(string personaje)
        {
            return "Hola" + personaje + " soy " + nombre;
        }







    }
}
