using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
   class Program
   {
      static void Main(string[] args)
      {
         //          Un importante negocio de desinfectante líquido realiza descuentos
         //          dependiendo de la cantidad de litros vendidos según la siguiente escala:
         //             a.Si vende menos de 100 litros, no hay descuento.
         //             b.Si vende entre 101 y 300 litros, el descuento es del 10 %.
         //             c.Si vende entre 301 y 500 litros, el descuento es del 15 %.
         //             d.Finalmente, si la venta es de más de 500 litros, el descuento es del 25 %.
         //          Hacer un programa que solicite el ingreso del importe total de la venta y la
         //          cantidad de litros vendidos y calcule y emita el importe con el descuento
         //          aplicado.

         int litrosVendidos;
         int descuento;
         Console.WriteLine("Ingrese la cantidad de litros vendidos:");
         litrosVendidos = int.Parse(Console.ReadLine());
         if (litrosVendidos >= 500)
         {
            descuento = 25;
            Console.WriteLine("Se aplicó un descuento del {0}%", descuento);
         }
         else if (litrosVendidos >= 300)
         {
            descuento = 15;
            Console.WriteLine("Se aplicó un descuento del {0}%", descuento);
         }
         else if (litrosVendidos > 100)
         {
            descuento = 10;
            Console.WriteLine("Se aplicó un descuento del {0}%", descuento);
         }
         else
         {
            Console.WriteLine("No se aplicó ningún descuento.");
         }

         Console.ReadKey();
      }
   }
}
