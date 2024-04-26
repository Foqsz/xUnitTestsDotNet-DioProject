using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalentsProcject
{
    public class Calculadora
    {
        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            return res;
        }

        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            return res;
        }

        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            return res;
        }

        public List<string> historico()
        {
            return new List<string>();
        }
    }
}
