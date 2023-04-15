using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    internal class Persona
    {
        
        public string nombre;
        public string apellido;
        private int legajo;

        public Persona(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void DarPresente()
        {

        }
        
        //public override string ToString()
        //{
          //  StringBuilder sb = new StringBuilder();
            //sb.AppendLine("-------");
            //sb.AppendLine($"Nombre: {nombre}");
            //sb.AppendLine($"Apellido: {apellido}");
            //sb.AppendLine();
        //}
        //
    }
}
