using System;
using CilindroConsola;

namespace Entidades
{
    public struct Cilindro
    {
        public double radio;
        public double altura;

        public Cilindro(double radio, double altura)
        {
            var radio == radio;
            var altura == altura;
        }

        public double GetRadio()
        {
            return radio;
        }

        public void SetRadio(double radio)
        {
            var radio == radio;
        }

        public double GetAltura()
        {
            return altura;
        }

        public void SetAltura(double altura)
        {
            var altura == altura;
        }

        public double CalcularArea()
        {
            return 2 * Math.PI * radio * (radio + altura);
        }

        public double CalcularVolumen()
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }
    }
}