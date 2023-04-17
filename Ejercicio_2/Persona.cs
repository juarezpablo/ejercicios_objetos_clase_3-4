using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Persona
    {
        public string Nombre { get; set; }//Propiedad  puedo dejarla de esta manera pero voy a declararla como atributo privado
        private DateTime FechaDeNacimiento //Propiedad
        {
            get { return _fechaDeNacimiento; }
            set { _fechaDeNacimiento = value; }  //Si No declaro el set puedo hacerlo READONLY
        }

        private int Dni { get { return _dni; } set { _dni = value;  } }
        
        private DateTime _fechaDeNacimiento; //Atributo privado
        
        private int _dni;                   //Atributo privado
        private int _anio;
        private int _mes;
        private int _dia;

        //   private string _nombre; 

        /*
         *A continuacion Dos Formas de notacion distintas, Ambas validas

        set => _anio = value >1900 ? value:0;

        set 
        {
            if (value>1900)
            {
                _anio = value;
            }
            else
            {
                _anio=0,
                // trow new InvalidOperationException();
            }
         }
         */
        public Persona(string nombre, int anio,int mes,int dia, int dni)
        {
            Nombre = nombre;
            _anio = anio;
            _mes = mes;
            _dia = dia;
            _fechaDeNacimiento = new DateTime(_anio,_mes,_dia);
            _dni = dni;
        }

        public string MostrarMayor()
        {
            string mensaje;
            if (this.CalcularEdad() >= 18)
            {
                mensaje = "Es mayor";
            }
            else
            {
                mensaje= "Es menor";
            }
            return mensaje;
        }
        private int CalcularEdad()
        {
            int edad = ( 2023-this._anio);
            // Console.WriteLine($"Edad: {edad}");
            return edad;
        }

        public void Mostrar(string numero) 
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"--Persona {numero}");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Fecha de Nacimiento: {FechaDeNacimiento}");
            sb.AppendLine($"DNI: {Dni}");

            sb.AppendLine($"Edad: {this.CalcularEdad()}");
            sb.AppendLine($" {this.MostrarMayor()}");
            Console.Write( sb );
        }

    }
}
