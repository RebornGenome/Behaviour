using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility.Handler
{
    public abstract class AbstractSoldier : ISoldier
    {
        private ISoldier _nextSoldier;

        public ISoldier SetNext(ISoldier soldier)
        {
            _nextSoldier = soldier;
            return soldier;
        }

        public virtual string GetCommand(string command)
        {
            if (_nextSoldier != null)
            {
                return _nextSoldier.GetCommand(command);
            }
            else
            {
                return null;
            }
        }
    }
}
