using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
   class Program
   {
      static void Main(string[] args)
      {
         //         Hacer un programa para ingresar dos números.Si el segundo es distinto de
         //cero, calcular la división del primero por el segundo y mostrar el resultado por
         //pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por
         //cero.

         int a, b;
         double operacion;
         Console.WriteLine("Ingrese un valor para el primer y segundo número:");
         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());

         if (b!=0)
         {
            operacion = (double)a/b;
            Console.WriteLine("El resultado de la división del primero por el segundo es: {0:F2}", operacion);
         }

         else
         {
            Console.WriteLine("No se puede dividir por 0.");
         }
         Console.ReadKey();
   }
}
}
