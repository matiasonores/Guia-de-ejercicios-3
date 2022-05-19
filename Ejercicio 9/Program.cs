using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
   class Program
   {
      static void Main(string[] args)
      {
         //         Una importante marca de computadoras permite elegir cierta configuración del
         //equipo a comprar.Para ello existe la siguiente escala de precios:
         //          i5(1)       i7(2)    i9(3)
         //8 RAM(1)  USD 800  USD 900  USD 1200
         //16 RAM(2) USD 900  USD 1000 USD 1400
         //32 RAM(3) USD 1000 USD 1400 USD 2000
         //Además, el equipo viene con un disco que permite almacenar 500 GB de
         //información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo
         //adicional de USD 300.
         //Hacer un programa que solicite la opción de procesador, la opción de memoria
         //RAM, y si extiende el disco o no(ingresa 1 para extender y 0 para no extender)
         //y calcule y emita por pantalla el monto de la máquina seleccionada.

         int procesador, ram, disco;
         double costo;

         Console.WriteLine("Ingrese la opción de procesador: i5(1) i7(2) i9(3)");
         procesador = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese la opción de ram: 8GB(1) 16GB(2) 32GB(3)");
         ram = int.Parse(Console.ReadLine());
         Console.WriteLine("Presione 1 si desea extender la capacidad del disco.");
         disco = int.Parse(Console.ReadLine());

         switch (procesador)
         {
            case 1:
               switch (ram)
               {
                  case 1:
                     costo = 800;
                     break;
                  case 2:
                     costo = 900;
                     break;
                  default:
                     costo = 1000;
                     break;
               }
               break;
            case 2:
               switch (ram)
               {
                  case 1:
                     costo = 900;
                     break;
                  case 2:
                     costo = 1000;
                     break;
                  default:
                     costo = 1400;
                     break;
               }
               break;
            default:
               switch (ram)
               {
                  case 1:
                     costo = 1200;
                     break;
                  case 2:
                     costo = 1400;
                     break;
                  default:
                     costo = 2000;
                     break;
               }
               break;
         }
         if (disco == 1)
            costo += 300;
         Console.WriteLine("El costo final de la compra es de: {0}", costo);

         Console.ReadKey();

      }
   }
}
