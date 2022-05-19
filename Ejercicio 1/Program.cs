using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite el ingreso de un número y que luego emita un
         //cartel por pantalla aclarando si el mismo es múltiplo de 5.

         int n;

         Console.WriteLine("Ingrese un valor para saber si múltiplo de 5:");
         n = int.Parse(Console.ReadLine());

         if (n % 5 == 0)
            Console.WriteLine("Es multiplo de 5.");

         Console.ReadKey();
      }
   }
   }
