using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    class Class2
    {
        public static int checkPrime(int num)
        {
            for(int i=2;i<=Math.Sqrt(num);i++)
            {
                if(num%i==0)
                {
                    
                    return 0;
                }
            }
            return 1;
        }
    }
}
