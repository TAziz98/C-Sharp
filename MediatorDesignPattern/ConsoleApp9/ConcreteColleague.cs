using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ConcreteColleague:Colleague
    {
        public ConcreteColleague(Mediator mediator) : base(mediator)
        {

        }
        
        public override void send(string message)
        {
            mediator.Send(message, this)
;        }
        public override void accept(string message)
        {
            Console.WriteLine(" accespted message " + message);
        }
    }
}
