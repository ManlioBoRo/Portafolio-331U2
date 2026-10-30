using System;
using Microsoft.VisualBasic;
namespace CS7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bloque de la función
            // Sesión 15: Funciones 15/10/2026
            /*
            Función: Bloque de instrucciones para realizar una tarea específica, que se ejecuta, unicamente, cuando es invocado.
            Sintaxis: Definición de función
            tipo_dato_devuelto identificador_función(parámetros)
            {
                Bloque_instrucciones
            }
            Nota 1: Los parámetros se definen incluyendo tipo de dato.
            Nota 2: Los parámetros van separados por comas.
            Sintaxis: Invocación de función
            identificador_función(argumentos);
            Argumento: El valor del parámetro.
            */
            // Ejemplo 1: Función vacía sin parámetros.}
            // Definición
            void Saludar()
            {
                string salón = "Exactas 331";
                Console.WriteLine($"¡Hola, {salón}!");
            }
            // Invocación
            Saludar();
            // 1. Definir e invocar una función sin parámetros para imprimir: nombre, clave y salón.
            void estudiante()
            {
                string nombre = "Manlio Bojórquez Manlio";
                string clave = "02";
                string salón = "331";
                Console.WriteLine($"Estudiante: {nombre} {salón}-{clave}\nNombre: {nombre}\nSalón: {salón}\nClave: {clave}");
            }
            estudiante();
            // 2. Definir e invocar una función sin parametros para desplegar el horario de hoy.
            void clase()
            {
                Console.WriteLine($"7:00-7:45 am: Cálculo diferencial\n7:50-8:35 am: Formacíon humana\n8:40-9:30 am: Programación\n9:50-10:35 am: Psicología\n10:50-11:30 am: Idiomas\n11:50 am-12:35 pm: Dibujo Tecnico\n12:40-13:30 pm: Dibujo Técnico");
            }
            clase();
            // Sesión 16: Función con parámetros.
            // return: Palabra reservada para terminar una función y devolver una expresión.
            // Ejemplo 1: Doble
            int CalcularDoble(int número)
            {
                int resultado = 2 * número;
                return resultado;
            }
            // Invocación
            int devolución;
            devolución = CalcularDoble(9);
            Console.WriteLine($"Devolución: {devolución}");
            // 1. Definir e invocar una función que devuelva la evaluación de la siguiente expresión: f(x)=4x-7/5
            double chocorrol(double x)
            {
                double y = 4 * x - 7/5d;
                return y;
            }
            double riko;
            riko = chocorrol(7.0d);
            Console.WriteLine($"y: {riko}");
        }
    }
}
