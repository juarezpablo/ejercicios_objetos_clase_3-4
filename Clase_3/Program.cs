using System.Text;

namespace Clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello, World!");
            Cuenta nuevaCuenta = new Cuenta("Enterprise", 25);
            //nuevaCuenta.mostrar();
            StringBuilder xb = new StringBuilder();
            xb.AppendLine("---MENU----");
            xb.AppendLine("1 - Mostrar datos");
            xb.AppendLine("2 - Ingresar  ");
            xb.AppendLine("3 - Retirar  ");
            xb.AppendLine();
            Console.WriteLine(xb);
            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        nuevaCuenta.mostrar();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto a acreditar: ");
                        int.TryParse(Console.ReadLine(), out int monto);
                        nuevaCuenta.ingresar(monto);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el monto a retirar: ");
                        int.TryParse(Console.ReadLine(), out int retiro);
                        nuevaCuenta.retirar(retiro);
                        break;

                }

            }
        }
    }
}