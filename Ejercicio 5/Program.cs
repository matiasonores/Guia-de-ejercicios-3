using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite el ingreso de las notas del primer parcial y del
         //segundo parcial de una alumna de programación. El programa deberá analizar
         //las notas y emitir la situación de la alumna según la siguiente escala:
         //         a.Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
         //         b.Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales(se
         //         aprueba con 6 o más), emitir “rinde examen final”.
         //         c.Si tiene menos de 6 en alguno de los dos parciales, emitir “debe
         //         recuperar”.
         //El programa debe emitir solo un cartel, el que corresponda.

         int nota1, nota2;
         Console.WriteLine("Ingrese un valor para la nota del primer y segundo parcial:");
         nota1 = int.Parse(Console.ReadLine());
         nota2 = int.Parse(Console.ReadLine());

         if(nota1>=8 && nota2 >= 8)
            Console.WriteLine("Aprobación directa.");
         else if (nota1<6||nota2<6)
            Console.WriteLine("Debe recuperar.");
         else 
            Console.WriteLine("Rinde examen final.");
         
         Console.ReadKey();

      }
   }
}
