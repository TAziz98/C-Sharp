using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Division : Operation
    {
        public override void operation(double firstValue, string MathOperation, double secondValue)
        {
            
            try
            {
                if(MathOperation!="/")
                  throw new Exception();

              double result = firstValue / secondValue;
                Console.WriteLine("Result :" + result);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("No Such operation "+ ex);
            }
           
            
        }
    }
}
