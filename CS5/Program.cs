using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Unidad 1: Estructuras de control II
               Unidad 2: Funciones II
               Sesióon 12: Instrucción while 30/09/2026
               Sintaxis: while
               Inicialización;
               while(expresión)
               {
                   Bloque de instrucciones
                   iterador;
               }
               Iterar: repetir*/
            // Ejemplo 1: Ciclo ascendente (rango: 1-3)
            int m = 1; // Inicialización
            while (m <= 3) // Expresión
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1; // Iterador
            }
            // Sesión 13: Instrucciones while 01/10/2026
            // 1. Definir un ciclo para imprimir tu nombre 5 veces.
            // Nota: Para la expresión utilizar el operador <.
            // a. Ciclo ascendente
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine("Manlio Bojórquez Rodríguez");
                n += 1;
            }
            // b. Ciclo decendente
            int d = 3;
            while (d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1;
            }
            // c. Incrementos
            // Secuencia: 3 6 9 12 15 18
            int i = 3;
            while (i <= 10)
            {
                Console.WriteLine($"i: {i}");
                i += 3;
            }
            // d. Decrementos
            // 1. Definir un ciclo para imprimir "331" 8 veces.
            // nota: Para la solución, define un ciclo descendente con decrementose de 2 unidades.
            int f = 16;
            while (f > 0)
            {
                Console.WriteLine("331");
                f -= 2;
            }
            // Actividad 1: Cilo infinito
            // 1. Definir un ciclo infinito ascendente.
            /*int k = 7;
            while (k > 0)
            {
                Console.WriteLine($"k: {k}");
                k += 1;
            }
            // 2. Definir un ciclo infinito descendente.
            // Nota: Para la Solución, utilizar el operador de diferencia
            int o = 7;
            while (o != 8)
            {
                Console.WriteLine($"o: {o}");
                o -= 1;
            }*/
            // Sesión 14: Actividad 2:Medio Maratón. Manlio Bojórquez Rodríguez 331-02
            // Este programa utilizara m.
            float c = 0f; // Diana no ha dado su primera zancada.
            int z = 0; // Diana empieza sin zancadas.
            while (c <= (21 * 1000)) // Tomando en cuenta que un km equivale a 1000 m, convertimos los 21 km a 21000 m.
            {
                c += .63f;
                z += 1;
            }
            Console.WriteLine($"Diana avanzó en {z} zancada(s) una distancia de {c} m.");
        }
    }
}