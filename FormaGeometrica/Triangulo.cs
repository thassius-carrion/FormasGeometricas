using System;
using System.Collections.Generic;
using System.Text;

namespace FormaGeometrica
{
    class Triangulo : IForma
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo()
        {
            ler();
        }

        public double area()
        {
            double area = baseTriangulo * altura / 2;
            return area;
        }

        public double perimetro()
        {
            double perimetro = baseTriangulo + (2 * altura);
            return perimetro;
        }

        public void ler()
        {
            Console.Write("Inserir Base: ");
            this.baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserir Altura: ");
            this.altura = Convert.ToDouble(Console.ReadLine());
        }

        public void imprimirResultados()
        {
            Console.WriteLine("Area do Triangulo: " + this.area());
            Console.WriteLine("Perimetro do Triangulo: " + this.perimetro());
        }
    }
}
