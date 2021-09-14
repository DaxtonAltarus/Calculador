using System;
using System.Collections.Generic;
using System.Text;

namespace Calculador
{
    class cAreas
    {
        public double acirculo(double radio)
        {
            return Math.PI * Math.Pow(radio,2);
        }
        public double arectangulo(double baser, double altura)
        {
            return baser * altura;
        }
        public double atriangulo(double cateto1,double cateto2)
        {
            return (cateto1 * cateto2) / 2;
        }
    }
}
