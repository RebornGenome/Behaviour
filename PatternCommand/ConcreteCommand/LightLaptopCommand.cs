using PatternCommand.Command;
using PatternCommand.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.ConcreteCommand
{
    public class LightLaptopCommand : ICommandTV
    {
        private readonly Light _light;

        public LightLaptopCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.IncreaseLight();
        }

        public void Cancel()
        {
            _light.DecreaseLight();
        }
    }
}
