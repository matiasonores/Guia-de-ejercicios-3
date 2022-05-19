using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
   class Program
   {
      static void Main(string[] args)
      {
         //         Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
         //son todos iguales entre sí, caso contrario, no emitir nada.

         int a, b, c, d;
         Console.WriteLine("Ingrese un valor para A,B,C y D:");

         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());
         c = int.Parse(Console.ReadLine());
         d = int.Parse(Console.ReadLine());

         if(a==b&&b==c&&c==d)
            Console.WriteLine("Los valores ingresados son iguales.");

         Console.ReadKey();
      }
   }
}
