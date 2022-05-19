using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar por teclado la longitud de los tres lados de un
         //triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo
         //de triángulo corresponde:
         //a.Equilátero: cuando los tres lados sean iguales.
         //b.Isósceles: cuando dos de los tres lados sean iguales.
         //c.Escaleno: cuando todos los lados sean distintos.

         int a, b,c;
         Console.WriteLine("Ingrese un valor para cada uno de los lados del triángulo:");
         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());
         c = int.Parse(Console.ReadLine());

         if(a==b&&b==c)
            Console.WriteLine("El triángulo es equilátero.");

         else if (a == b || b == c || c==a)
            Console.WriteLine("El triángulo es isósceles.");
         
         else
            Console.WriteLine("El triángulo es escaleno.");

         Console.ReadKey();
      }
   }
}
