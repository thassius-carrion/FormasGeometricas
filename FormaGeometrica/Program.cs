using System;
using System.Collections.Generic;

namespace FormaGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            IForma quadrado1 = new Quadrado();
            IForma triangulo1 = new Triangulo();
            IForma circulo1 = new Circunferencia();

            List<IForma> formas = new List<IForma>();

            formas.Add(quadrado1);
            formas.Add(triangulo1);
            formas.Add(circulo1);

            formas.ForEach(forma => forma.imprimirResultados());

            /*foreach (IForma forma in formas)
            {
                forma.imprimirResultados();
            }*/

        }
    }
}
