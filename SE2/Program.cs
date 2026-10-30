using System;
namespace SE2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bloque de instrucciónes
            // Sesión 17: Solución de examen
            // 1. Sintaxis: Función
            /*
            tipo_de_dato_devuelto identificador_de_la_función(parámetros)
            {
                Bloque de instrucciones
            }
            */
            // 2. Ciclo ascendente
            int i = 2;
            while (i <= 27)
            {
                Console.WriteLine($"i: {i}");
                if (i < 6)
                {
                    i += 2;
                }
                else if (i < 15)
                {
                    i += 3;
                }
                else
                {
                    i += 4;
                }
            }
            // 3. Ciclos
            int inicio = 9;
            int límite = 22;
            int producto;
            producto = inicio * límite;
            if (producto < 8 && inicio > límite)
            {
                // Bloque de instrucciones
                // Ascendente
                int m = 9;
                while (m >= 1)
                {
                    m -= 1;
                }
            }
            else
            {
                // Bloque de instrucciones
                // Descendente
                int n = 3;
                while (n <= 8)
                {
                    n += 1;
                }
            }
            // 4. Múltiplo de 5
            bool CalcularMúltipo(int número)
            {
                bool resultado = false;
                if (número % 5 == 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            bool resultado = CalcularMúltipo(32);
            Console.WriteLine($"Devolución: {resultado}");
            // 5. Función vacía
            void ImprimirTexto(string materia)
            {
                Console.WriteLine($"Examen: {materia}");
            }
            ImprimirTexto("Programación III");
        }
    }
}