using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Primer lote con 10 registros de productos, cada producto tiene:
                - Código Artículo (3 dígitos no correlativos)
                - Precio
                - Código Cliente (1 a 100)
            Segundo lote con las ventas de la semana. Cada venta tiene:
                - Código Artículo
                _ Cantidad
                - Código Cliente (1 a 100)
            Este lote corta con Código de Cliente cero */

            /*Creo un vector de 10 elementos de mi CLASE ARTICULO, que tiene los 
             tres atributos dentro. Esto me ahorra tener que hacer tres vectores
             distintos y relacionar los índices de cada vector para que estén 
             correctos los datos.*/
            Articulo[] articulos = new Articulo[10];

            /*Lo que hago con este ciclo es poder cargar los 3 atributos que me pide
              (de 10 elementos), con la particularidad que lo carga en un solo vector*/
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese los datos del producto: ");

                Console.WriteLine("Ingrese el código: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Ingrese el precio: ");
                articulos[i].Precio = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la marca (1 a 10): ");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
            }
            //cargado el vector completo con los 10 artículos

            Venta venta = new Venta();//armo todo con un objeto, en vez de una variable simple

            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Ingrese código de cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Ingrese código de artículo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine();

                //lógica del código

                //pido cliente de nuevo
                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Ingrese código de cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
