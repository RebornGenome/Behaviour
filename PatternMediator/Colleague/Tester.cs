using PatternMediator.ConcreteMediator;
using PatternMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMediator.Colleague
{
    public class Tester : Employee
    {
        public Tester(IMediator mediator) : base(mediator) { }

        public void ExecuteWorkTester()
        {
            _mediator.Notification("Проект протестирован.", this);
        }
    }
}
