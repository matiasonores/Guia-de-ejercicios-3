using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite el ingreso de dos números y luego calcular:
         //         a.La resta si el primero es mayor que el segundo.
         //         b.La suma si son iguales.
         //         c.El producto si el primero es menor.
         //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

         int a, b;
         int operacion;
         Console.WriteLine("Ingrese un valor para el primer y segundo número:");
         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());

         if (a == b)
         {
            operacion = a + b;
         Console.WriteLine("La suma es: {0}", operacion);
      }

         else if (a > b)
         {
            operacion = a - b;
         Console.WriteLine("La resta es: {0}", operacion);
      }

         else
         {
            operacion = a * b;
         Console.WriteLine("El producto es: {0}", operacion);
      }
         Console.ReadKey();
   }
   }
}
