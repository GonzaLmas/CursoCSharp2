using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_y_Colecciones
{
    internal class Camioneta : Vehiculo //con el ":" digo que camioneta ES un vehículo y hereda las propiedades de esa class
    {
        public float CargaMax { get; set; }

        public string Color { get; set; }

    }
}
