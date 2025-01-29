using PatternCommand.Command;
using PatternCommand.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PatternCommand.ConcreteCommand
{
    public class LaptopCommand : ICommandTV
    {
        private readonly Laptop _laptop;

        public LaptopCommand(Laptop laptop)
        {
            _laptop = laptop;
        }

        public void Execute()
        {
            _laptop.OnLaptop();
        }

        public void Cancel()
        {
            _laptop.OffLaptop();
        }
    }
}
