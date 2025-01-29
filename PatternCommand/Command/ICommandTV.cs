using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Command
{
    public interface ICommandTV
    {
        public void Execute();

        public void Cancel();
    }
}
