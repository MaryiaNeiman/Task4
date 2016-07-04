using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Task4_2
{
    public  class Mathematics
    {


        public static double Fibonacci (int n)
        {
            double fi = (1 + Math.Sqrt(5)) / 2;
            return (Math.Pow(fi, n) - Math.Pow(-fi, -n)) / (2 * fi - 1);

        }

        public static BigInteger ProdTree(int l, int r)
        {
          
            if (l > r)
                return 1;
            if (l == r)
                return l;
            if (r - l == 1)
                return (BigInteger)l * r;
            int m = (l + r) / 2;
            return ProdTree(l, m) * ProdTree(m + 1, r);
        }

       public static BigInteger FactTree(int n)
        {
            if (n < 0)
                return 0;
            if (n == 0)
                return 1;
            if (n == 1 || n == 2)
                return n;
            return ProdTree(2, n);
        }


    }
}
