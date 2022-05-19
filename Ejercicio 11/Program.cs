using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar tres números y luego mostrarlos ordenados de menor a mayor.

         int a, b, c, mayor, medio, menor;
         Console.WriteLine("Ingrese un valor para A, B y C:");

         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());
         c = int.Parse(Console.ReadLine());

         if (a > b && a > c)
            mayor = a;
         else if (b > a && b > c)
            mayor = b;
         else 
            mayor = c;

         if (a < b && a < c)
            menor = a;
         else if (b < a && b < c)
            menor = b;
         else 
            menor = c;

         if (mayor == a && menor == b)
            medio = c;
         else if (mayor == b && menor == c)
            medio = a;
         else
            medio = b;

         Console.WriteLine("El menor es {0}",menor);
         Console.WriteLine("El medio es {0}",medio);
         Console.WriteLine("El mayor es {0}",mayor);
         Console.ReadKey();
      }
   }
}
