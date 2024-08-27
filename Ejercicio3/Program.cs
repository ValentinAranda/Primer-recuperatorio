using System;
using Cilindro;

namespace CilindroConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            Console.Write("Ingrese el radio del cilindro: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            cilindro.SetRadio(radio);

            Console.Write("Ingrese la altura del cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            cilindro.SetAltura(altura);

            Console.WriteLine("El área del cilindro es: " + cilindro.CalcularArea());
            Console.WriteLine("El volumen del cilindro es: " + cilindro.CalcularVolumen());

            Console.ReadKey();
        }
    }
}
