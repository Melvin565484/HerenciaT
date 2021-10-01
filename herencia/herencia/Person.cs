using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    // Clase padre o base 
    class Person

        
        
        //Ingeniera comentarle que nos reunimos con el compañero Erick Benitez Cano para desarrollar
        //la actividad ya que vivimos muy cerca y a el se le dificulta ya que no tiene una maquina capaza de correr el programa
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
