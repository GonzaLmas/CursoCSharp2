using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_y_Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            //Herencia
            Vehiculo v2 = new Camioneta(); //estoy guardando una variable de tipo camioneta dentro de un vehículo pq la camioneta es un vehículo, al revés da error pq no respeta la jerarquía
            Vehiculo v3 = new AutoDeportivo();//estoy creando UN OBJETO "aueto deportivo"

            c1.Color = "Amarillo";
            c2.Color = "Rojo";
            c3.Color = "Blanco";

            //Las colecciones vendrían a ser "vectores" dinámicos. No le indíco el tamaño.

            //Colecciones: listas
            List<Camioneta> listacamionetas = new List<Camioneta>();//creo una lista de objetos de "camionetas"
            listacamionetas.Add(c1);//la lista ya tiene un elemento "camioneta" adentro
            listacamionetas.Add(c2);//la lista ya tiene dos elementos "camioneta" adentro
            listacamionetas.Add(c3); //la lista ya tiene tres elementos "camioneta" adentro

            Console.WriteLine("La cant de camionetas es: " + listacamionetas.Count);//lo que hace el count es contar la cant de elementos que hay dentro de la lista
            listacamionetas[1].Color = "Negro";//sobreescribo lo que asigné en la línea 23. En vez de mostrar "Rojo" va a mostrar "Negro"
            c2.Color = "Verde";//asignándole otro string a c2, lo sobreescribe a pesar de que se haya asignado luego de crear la lista (línesa 31)
            Console.WriteLine("El color es: " + listacamionetas[1].Color);//va a mostrar el color del segundo elemento de la lista (en este caso el rojo)

            listacamionetas.Remove(c3);//remuevo el objeto c3 de la lista

            Console.WriteLine("La cant de camionetas es: " + listacamionetas.Count); 

            //Para recorrer toda la lista:

            foreach (Camioneta camioneta in listacamionetas)
            {
                Console.WriteLine("Color: " + camioneta.Color);
            }







            Console.ReadKey();





        }
    }
}
