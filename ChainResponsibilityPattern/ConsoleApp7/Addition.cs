﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Addition :Operation
    {
        
        public override void operation(double firstValue,string MathOperation, double secondValue)
        {
            
            if (MathOperation != "+")
            {
                Subtraction subtraction = new Subtraction();
             subtraction.operation(firstValue, MathOperation, secondValue);
            }
            else
            {
                double result = firstValue + secondValue;
                Console.WriteLine("Result :"+result);
            }
           
        }
    }
}
