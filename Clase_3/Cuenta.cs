using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    internal class Cuenta
    {
        public string titular;
        public int cantidad;

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public void mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------");
            sb.AppendLine($"Titular: {titular}");
            sb.AppendLine($"Cantidad: {cantidad}");
            sb.AppendLine();
            Console.WriteLine(sb);
        }
        public string GetTitular() 
        { 
            return titular; 
        }
        public int GetCantidad()
        {
            return cantidad;
        }

        public void ingresar(int monto)
        {
            if (monto >= 0)
            {
                this.cantidad += monto;
           
                Console.WriteLine($"Cantidad: {this.cantidad.ToString()}");
            }
        }

        public void retirar(int monto)
        {
            this.cantidad -= monto;
            Console.WriteLine($"Cantidad: {this.cantidad.ToString()}");
        }

    }
}
