using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {
        /* - Código Artículo(3 dígitos no correlativos)
           - Precio
           - Código Cliente(1 a 100)*/

        /*forma reducida de armar la propiedad completa (como la de Botella)
         La desventaja de escribir la propiedad de forma corta, es que NO puedo
        manipuliar lo que pasas dentro del getter y el setter.*/
        public int CodigoArticulo { get; set; }// forma reducida de armar la propiedad (Sin el set, es una propiedad de solo lectura)

        public float Precio { get; set; }// forma reducida de armar la propiedad


        private int codMarca;//manejo el atributo por separado
        public int CodigoMarca//creo propiedad de manera larga
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)//si el valor que carga la persona cumple
                    codMarca = value;//a codMarca le cargo ese valor
                else
                    codMarca = -1;//sino, le cargo un -1
            }
        }








    }
}
