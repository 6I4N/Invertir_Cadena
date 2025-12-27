/*
Invertir una cadena
Pide una palabra y muéstrala invertida.

Ejemplo:
hola → aloh

No uses Reverse()
*/
namespace Invertir_Cadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();

            char[] letras = new char[palabra.Length];

            for(int i = 0; i < palabra.Length; i++)
            {
                letras[i] = palabra[i];
            }

            for (int j = letras.Length - 1; j >= 0; j--)
            {
                Console.Write(letras[j]);
            }
        }
    }
}
