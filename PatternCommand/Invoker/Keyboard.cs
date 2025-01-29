using PatternCommand.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Invoker
{
    public class Keyboard
    {
        List<ICommandTV> commands;
        Stack<ICommandTV> commandsHistory;

        public Keyboard()
        {
            commands = new List<ICommandTV>() { null, null };
            commandsHistory = new Stack<ICommandTV>();
        }

        public void SetCommands(int button, ICommandTV command)
        {
            commands[button] = command;
        }

        public void ButtonPress(int button)
        {
            if (commands[button] != null)
            {
                commands[button].Execute();
                commandsHistory.Push(commands[button]);
            }
        }

        public void ButtonUp()
        {
            if (commandsHistory.Count > 0)
            {
                commandsHistory.Pop().Cancel();
            }
        }
    }
}
