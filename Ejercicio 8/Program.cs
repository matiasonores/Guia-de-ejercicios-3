using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
   class Program
   {
      static void Main(string[] args)
      {
         //         El negocio de desinfectante antes mencionado vende además detergente
         //suelto, y los precios se aplican según la siguiente escala:
         //a. 25 ARS por litro los primeros 50 litros.
         //b. 20 ARS por litro si la venta es de 51 a 200 litros.
         //c. 15 ARS por litro si la venta es de 201 a 500 litros.
         //d. 10 ARS por litro si la venta es de más de 500 litros.
         //Además, si paga en efectivo, tiene un adicional del 10 % sobre el importe final.
         //Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago
         //(ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule
         //y emita por pantalla el monto final a abonar por el cliente.

         int litrosVendidos;
         int precio;
         double valorFinal;
         Console.WriteLine("Ingrese la cantidad de litros vendidos:");
         litrosVendidos = int.Parse(Console.ReadLine());
         Console.WriteLine("Si desea pagar en efectivo presione 1.");
         int metodoPago = int.Parse(Console.ReadLine());
         if (litrosVendidos > 500)
         {
            precio = 10*litrosVendidos;
            Console.WriteLine("Valor del litro: $10.");
         }
         else if (litrosVendidos > 200)
         {
            precio = 15 * litrosVendidos;
            Console.WriteLine("Valor del litro: $15.");
         }
         else if (litrosVendidos > 50)
         {
            precio = 20 * litrosVendidos;
            Console.WriteLine("Valor del litro: $20.");
         }
         else
         {
            precio = 25 * litrosVendidos;
            Console.WriteLine("Valor del litro: $25.");
         }

         if (metodoPago == 1)
         {
            valorFinal = (double)precio * 0.9;
            Console.WriteLine("Se aplicó un descuento del 10%.");
         }
         else
            valorFinal = (double)precio;

         Console.WriteLine("El valor final de su compra es de:{0, 0:C2}", valorFinal);

         Console.ReadKey();
      }
   }
}
