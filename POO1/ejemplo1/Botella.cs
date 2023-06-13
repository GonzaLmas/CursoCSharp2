using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        /*CREO UN CONSTRUCTOR: función que me permite recibir valores iniciales, cargarlos
          en mis atributos para que NO se puedan escribir desde el exterior*/
        /* Al momento de hacer "new Botella" en el program, voy a necesitar recibir un
           string para color y otro string para material. Al yo crear MI propio constructor,
           lo que hago es pisar al constructor por defecto que es el de la CLASE OBJECT*/
        public Botella(string color, string material)//función que recibe parámetros y tiene una lógica
        {
            this.color = color;//el "this" apunta a la clase. Lo que hace acá es: con el this dice "YO, objeto, YO, la botella, MI COLOR", asigname el color que vino por parámetro
            this.material = material;
            capacidad = 100;
            cantActual = 0;
        }

        //SOBRECARGO EL CONSTRUCTOR
        public Botella() { }//función que no recibe parámetros ni tiene lógica


        //DESTRUCTOR: borra en la RAM lo que se ejecutó y ya no se va a utilizar de vuelta
        ~Botella()
        {
            //la lógica...
        }


        //Botella: Capacidad, Color, Material

        private int capacidad;
        private string color;
        private string material;
        private int cantActual;
       
        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantActual
        {
           get { return cantActual; } 
        }

        //PROPIEDAD

        //cuando invoque a "Capacidad", va a retornar el valor de capacidad.
        /*Con esta forma reemplazo la manera de declarar que hice en Persona.
        En Persona tengo dos métodos y en Botella tengo uno solo. */
        /*public int Capacidad 
        {
            get { return capacidad; }//getter
            set { capacidad = value; }//setter
        }*/
        
        /*La diferencia de crear una propiedad a crear dos métodos, es también 
        a la hora de asignar un valor. Con una propiedad asigno valores como si 
        fuera una variable de toda la vida.*/

        public float recargar()//método. Toma la cantidad actual, le asigna un 100 (capacidad Max) y te devuelve 50 (costo)
        {
            if (cantActual > 0)
            {
                int dif = capacidad - cantActual;
                float monto = dif * 50 / 100;
                cantActual += dif;
                return monto;
            }
            cantActual = 100;
            return 50;
        }

        public float recargar(int cantidad)
        {
            cantActual += cantidad;
            return cantidad * 50 / 100;
        }




    }
}
