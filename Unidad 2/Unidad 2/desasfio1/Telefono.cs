using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desasfio1
{
    internal class Telefono
    {   
        //Creo los atributos de la clase PUNTO 3
             
       // private int codigoOperador;
        private string Modelo;
        private string Marca;
        private string NumeroTelefonico;

        //Agrego las propiedades PUNTO 4
        public string Modelo { get; }

        public string Marca { get; }

        public string NumeroTelefonico;
        
        public void setNumeroTelefonico(int n)
        {
            NumeroTelefonico = n;
        }

        public int getNumeroTelefonico()
        {
            return NumeroTelefonico;
        }




        public void getCodigoOperador(int codigo)
        {        
            codigoOperador = codigo;          
        }

        public int setCodigoOperador()
        {
            if (codigoOperador >= 1 && codigoOperador <= 3)
                return codigoOperador;
            else
                return 0;
        }
        

        //Creo un constructor PUNTO 5   
        public Telefono (string modelo, string marca)
        {
            this.Modelo = modelo;
            this.Marca = marca;
        }
     









    }
}
