using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
   class Program
   {
      static void Main(string[] args)
      {
         //         Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si
         //la suma de los dos primeros es mayor al producto del segundo con el tercero.

         int a, b, c;
         Console.WriteLine("Ingrese un valor para A, B y C:");

         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());
         c = int.Parse(Console.ReadLine());

         if(a+b>b*c)
            Console.WriteLine("La suma de los dos primeros es mayor al producto de los dos últimos.");

         Console.ReadKey();
      }
   }
}
