using System;
using System.Collections.Generic;
using System.Text;

namespace FormaGeometrica
{
    class Quadrado : IForma
    {
        private double lado { get; set; }
        private double altura { get; set; }

        public Quadrado()
        {
            ler();
        }

        public double area()
        {
            double area = lado * altura;
            return area;
        }

        public double perimetro()
        {
            double perimetro = 2 * lado + 2 * altura;
            return perimetro;
        }

        public void ler()
        {
            Console.Write("Inserir Lado: ");
            this.lado = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserir Altura: ");
            this.altura = Convert.ToDouble(Console.ReadLine());
        }

        public void imprimirResultados()
        {
            Console.WriteLine("Area do Quadrado: " + this.area());
            Console.WriteLine("Perimetro do Quadrado: " + this.perimetro());
        }
    }
}
