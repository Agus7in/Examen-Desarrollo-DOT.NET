using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Flow_Technology_Agustin_Martinez
{
    class Factorial
    {
        public Factorial() { }
        public Factorial(int n) { }

        public int FactorialN(int n)
        {
            if (n > 0)
            {
                int valor = n * FactorialN(n - 1);
                return valor;
            }
            else
            {
                return 1;
            }
        }
    }
}
