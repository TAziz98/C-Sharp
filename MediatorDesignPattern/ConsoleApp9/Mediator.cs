using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
   abstract class Mediator
    {
        public abstract void Send(string message,Colleague colleague);
    }
}
