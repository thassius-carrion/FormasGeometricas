using System;
using System.Collections.Generic;
using System.Text;

namespace FormaGeometrica
{
    interface IForma
    {
        public double area();
        public double perimetro();
        public void ler();
        public void imprimirResultados();
    }
}
