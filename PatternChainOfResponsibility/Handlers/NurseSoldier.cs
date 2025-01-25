using PatternChainOfResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility.Handlers
{
    public class NurseSoldier : AbstractSoldier
    {
        public override string GetCommand(string command)
        {
            if (command == "Перебинтовала солдата")
            {
                return $"Медсестра выполнила команду -> {command.ToString()}";
            }
            else
            {
                return base.GetCommand(command);
            }
        }
    }
}
