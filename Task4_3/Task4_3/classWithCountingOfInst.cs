using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_3
{
    class ClassWithCountingOfInst
    {
        private static int countOfInstance = 0;

        public ClassWithCountingOfInst()
        {
            countOfInstance++;
        }
    }
}
