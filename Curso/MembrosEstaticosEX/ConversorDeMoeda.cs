using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticosEX
{
    class ConversorDeMoeda
    {
        public static double iof = 1.06;

        public static double CalcularValor(double cota, double dolar)
        {
            return (cota * dolar) * iof;
        }
    }
}
