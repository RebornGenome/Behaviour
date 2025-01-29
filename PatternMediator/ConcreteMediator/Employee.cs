using PatternMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMediator.ConcreteMediator
{
    public abstract class Employee
    {
        protected IMediator _mediator;

        public Employee(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediatorr)
        {
            _mediator = mediatorr;
        }
    }
}
