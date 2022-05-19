using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar 4 números.Luego analizar e informar por
         //pantalla si los mismos se encuentran ordenados de forma decreciente.

         int a, b, c, d;
         Console.WriteLine("Ingrese un valor para A,B,C y D:");

         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine()); 
         c = int.Parse(Console.ReadLine());
         d = int.Parse(Console.ReadLine());

         if(a>b&& b > c&& c > d)
           Console.WriteLine("Los números estan en orden decreciente.");
         else
            Console.WriteLine("No están en orden decreciente.");

         Console.ReadKey();

      }
   }
}
