using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Telefono
    {
       public Telefono(string Modelo, string Marca)
       {
            this.Modelo = Modelo;
            this.Marca = Marca;
       }
               
        public string Modelo { get; }
        public string Marca { get; }

        public string NumTelefonico;

        public int CodOp;

        public string contacto;


        public string setNumTelefonico(string num)
        {
            NumTelefonico = num;
            return NumTelefonico;
        }

        public string getNumTelefonico()
        {
            return NumTelefonico;
        }


        public int setCodOp(int c)
        {
            if (c >= 1 && c <= 3)
            {           
                CodOp = c;
                return CodOp;
            }
            else
                return 0;         
        }

        public int getCodOp()
        {
            return CodOp;
        }



        public string Llamar()
        {
            return "Realizando llamada...";
        }

        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }
        


    }
}
