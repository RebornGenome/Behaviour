using PatternChainOfResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility.Handlers
{
    public class SniperSoldier : AbstractSoldier
    {
        public override string GetCommand(string command)
        {
            if (command == "Выстрелил со Снайперской Винтовки")
            {
                return $"Снайпер выполнил команду -> {command.ToString()}";
            }
            else
            {
                return base.GetCommand(command);
            }
        }
    }
}
