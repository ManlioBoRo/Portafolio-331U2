using System;
using System.Runtime.InteropServices;
namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sesión 13: Iteradores
            float c = 0f; // Diana no ha dado su primera zancada.
            int z = 0; // Diana empieza sin zancadas.
            int h = 1;
            while (c <= (21 * 1000)) // Tomando en cuenta que un km equivale a 1000 m, convertimos los 21 km a 21000 m.
            {
                if (c >= h*2000)
                {
                    Console.WriteLine($"Hidratación: {h}");
                    h++;
                }
                else{}
                c += .63f;
                z += 1;
            }
            Console.WriteLine($"Diana avanzó en {z} zancada(s) una distancia de {c} m.");
            // 1. Ciclo for
            /* Sintaxis: ciclo for
            for(inicialización; expresión; iterador)
            {
                //Bloque de instrucciones
            }
            */
            // Ejemplo: Secuencia 35-41
            for (int m = 35; m <= 41; m++)
            {
                Console.WriteLine($"m: {m}");
            }
            // Sesión 14: Ciclo for
            // 1. Definir un ciclo for para la siguiente secuencia: -33--39
            for (int n = -33; n >= -39; n--)
            {
                Console.WriteLine($"n: {n}");
            }
            Console.WriteLine($"Ciclo 1: Decendente");
            for (int n = -33; n >= -39; n--)
            {
                Console.WriteLine($"n: {n * -1}");
            }
            Console.WriteLine($"Ciclo 2: Ascendente");
            for (int a = 9; a <= 15; a += 1)
            {
                if (a < 13 || a > 13)
                {
                    Console.WriteLine($"a: {a}");
                }
            }
            // Un libro tiene un título distinto por cada 88 páginas, teniendo el primer título en la página 1. Escribir un programa para imprimir todos los capítulos, considerando que el libro contiene 539 páginas.
            int título = 1;
            for (int página = 1; página < 539; página ++)
            {
                if (página == título * 88 + 1)
                {
                    Console.WriteLine($"Página: {página}\nTítulo: {título}");
                    título ++;
                }
            }
        }
    }
}