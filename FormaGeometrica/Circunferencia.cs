using System;
using System.Collections.Generic;
using System.Text;

namespace FormaGeometrica
{
    class Circunferencia : IForma
    {
        private double raio;

        public Circunferencia()
        {
            ler();
        }

        public double area()
        {
            double area = Math.PI * raio * raio;
            return area;
        }

        public double perimetro()
        {
            double perimetro = 2 * Math.PI * raio;
            return perimetro;
        }

        public void ler()
        {
            Console.Write("Inserir Raio: ");
            this.raio = Convert.ToDouble(Console.ReadLine());
        }

        public void imprimirResultados()
        {
            Console.WriteLine("Area da Circunferencia: " + this.area());
            Console.WriteLine("Perimetro da Circunferencia: " + this.perimetro());
        }
    }
}
