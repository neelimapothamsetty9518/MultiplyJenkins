using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplyjenkins
{
    public class Multiply
    {
        //int size = 5;
        public  bool Mul(int size)
        {
            for(int i=1;i<=size;i++)
            {
                for(int j=1;j<=size;j++)
                {
                    int result = i * j;
                    Console.WriteLine(result);
                }
            }
            return true;
        }
    }
}
