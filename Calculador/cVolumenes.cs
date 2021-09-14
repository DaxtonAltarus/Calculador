using System;
using System.Collections.Generic;
using System.Text;

namespace Calculador
{
    class cVolumenes
    {
        public double vcono(double radio, double altura)
        {
            return Math.PI * Math.Pow(radio, 2) * altura/3;
        }
        public double vcilindro(double radio, double altura)
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }
        public double vesfera(double radio)
        {
            return Math.PI * Math.Pow(radio, 3)*4/3;
        }
    }
}
