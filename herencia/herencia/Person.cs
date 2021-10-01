using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    // Clase padre o base 
    class Person

    {
        //propiedades
        public string name { get; set; }

        //metodos
        public string registrar()
        {
            return "Registrando: " + name;
        }
         public string consultar()
        {
            return "Consultando";
        }
        public string sueldo()
        {
            return "Sueldo";
        }

    }
}