using System.Text;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Persona personaUno = new Persona("Pedro", 2000,4,5 , 34909999);
            Persona personaDos = new Persona("Juan", 1990, 3, 8, 34555678);
            Persona personaTres = new Persona("Ernesto", 2014, 5, 7, 36705444);
          




            StringBuilder xb = new StringBuilder();
            xb.AppendLine("---MENU----");
            xb.AppendLine("1 - Mostrar Fecha de Nacimiento");
            xb.AppendLine("2 - Mostrar  ");
            xb.AppendLine("3 -  ");
            xb.AppendLine();
            Console.WriteLine(xb);
           
            if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            
                            break;
                        case 2:
                            
                            personaUno.Mostrar("Uno");
                            personaDos.Mostrar("Dos");
                            personaTres.Mostrar("Tres");
                            break;
                        case 3:
                            //Console.WriteLine("Ingrese el monto a retirar: ");
                            //int.TryParse(Console.ReadLine(), out int retiro);
                           // nuevaCuenta.retirar(retiro);
                            break;

                    }

                }

        }
    }
}