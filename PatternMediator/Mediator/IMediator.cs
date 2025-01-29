using PatternMediator.ConcreteMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMediator.Mediator
{
    public interface IMediator
    {
         void Notification(string message, Employee employee);
    }
}
