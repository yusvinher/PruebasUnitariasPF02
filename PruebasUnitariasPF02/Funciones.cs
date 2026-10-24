using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasUnitariasPF02
{
    public class Funciones
    {
        public static long CalcularFactorial(int n)
        {

            if (n < 0)
                return -1;

            long factorial = 1;

            for (int i = 2; i <= n; i++)
                factorial *= i;

            return factorial;
        }
    }
}
