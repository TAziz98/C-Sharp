using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ConcreteMediator : Mediator
    {
      public ConcreteColleague concreteColleague { get; set; }
      public ConcreteColleague2 concreteColleague2 { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == concreteColleague)
            {
                concreteColleague2.accept(message);
            }
            else
            {
                concreteColleague.accept(message);
            }
        }
    }
}
