using PatternChainOfResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility.Handlers
{
    public class Minesweeper : AbstractSoldier
    {
        public override string GetCommand(string command)
        {
            if (command == "Разминировал мины")
            {
                return $"Сапер выполнил команду -> {command.ToString()}";
            }
            else
            {
                return base.GetCommand(command);
            }
        }
    }
}
