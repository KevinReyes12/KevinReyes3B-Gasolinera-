using System;
using Gasolinera.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            Gasolina g = new Gasolina();
            Console.WriteLine("Ingrese los apellidos del cliente: ");
            c.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese los nombres del cliente: ");
            c.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese el número de cédula de identidad: ");
            c.Numero_CI = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del cliente");
            c.Direccion = Console.ReadLine();
            
            Console.WriteLine("Ingrese el tipo de gasolina: ");
            g.Tipo = Console.ReadLine();
            if (g.Tipo.ToUpper() == "EXTRA")
            {
                g.Precio_venta = 1.50f;
            }
            else
            {
                if (g.Tipo.ToUpper() == "SUPER")
                {
                    g.Precio_venta = 2.00f;
                }
                else
                {
                    throw new Exception("Ingrese el tipo: Extra o Super");
                }
            }
            Console.WriteLine("Ingrese La cantidad de galones: ");
            g.Cant_galones = float.Parse(Console.ReadLine());
           
           
            Console.WriteLine("\n");
            //Impresion
            Console.WriteLine("******** Datos del cliente ********");
            Console.WriteLine(c.Apellidos+" "+c.Nombres);
            Console.WriteLine("Cédula de identidad :"+c.Numero_CI);
            Console.WriteLine("Dirección: "+c.Direccion);
            Console.WriteLine("\n");
            Console.WriteLine("******** Gasolina ********");
            Console.WriteLine("Tipo: "+g.Tipo.ToUpper());
            Console.WriteLine("Cantidad de galones: "+g.Cant_galones);
            Console.WriteLine("\n");
            Console.WriteLine("******** Valores a cancelar ********");
            Console.WriteLine("SUBTOTAL: "+g.Subtotal);
            Console.WriteLine("IVA: "+g.IVA);
            Console.WriteLine("TOTAL: "+g.Total);

            Console.ReadKey();
        }
        
    }
}
