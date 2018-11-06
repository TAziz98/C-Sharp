using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleague Trump = new ConcreteColleague(mediator);
            ConcreteColleague2 Putin = new ConcreteColleague2(mediator);
            mediator.concreteColleague = Trump;
            mediator.concreteColleague2 = Putin;
            Trump.send("How was the press conference in Helsinki");
            Putin.send("To be honest , not that good , how I was expected");
        }
    }
}
