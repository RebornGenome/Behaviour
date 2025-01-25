using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility.Handler
{
    public interface ISoldier
    {
        ISoldier SetNext(ISoldier soldier);

        string GetCommand(string command);
    }
}
