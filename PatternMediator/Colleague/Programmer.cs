using PatternMediator.ConcreteMediator;
using PatternMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMediator.Colleague
{
    public class Programmer : Employee
    {
        public Programmer(IMediator mediator) : base(mediator) { }

        public void ExecuteWorkProgrammer()
        {
            _mediator.Notification("Проектирую Проект.", this);
        }
    }
}
