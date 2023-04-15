using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Persona
    {
        public string Nombre { get; set; }//Propiedad
        private DateTime FechaDeNacimiento //Propiedad
        {
            get { return _fechaDeNacimiento; }
           // set { _fechaDeNacimiento = value; }  READONLY
        }

        private int Dni 
        { get { return _dni; }  }
        
        private DateTime _fechaDeNacimiento; //Atributo privado
        private int _dni;                   //Atributo privado



    }
}
