using PatternMediator.ConcreteMediator;
using PatternMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMediator.Colleague
{
    public class Director : Employee
    {
        public Director(IMediator mediator) : base(mediator) { }

        public void ExecuteWorkDirector()
        {
            _mediator.Notification("Есть Заказ!", this);
        }
    }
}
