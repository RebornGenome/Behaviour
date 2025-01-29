using PatternCommand.ConcreteCommand;
using PatternCommand.Invoker;
using PatternCommand.Receiver;

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop = new Laptop();
        Light light = new Light();
        Keyboard keyboard = new Keyboard();

        keyboard.SetCommands(0, new LaptopCommand(laptop));
        keyboard.SetCommands(1, new LightLaptopCommand(light));

        keyboard.ButtonPress(0);

        keyboard.ButtonPress(1);
        keyboard.ButtonPress(1);
        keyboard.ButtonPress(1);
        keyboard.ButtonPress(1);
        keyboard.ButtonPress(1);

        Console.Write("\n");

        keyboard.ButtonUp();
        keyboard.ButtonUp();
        keyboard.ButtonUp();
        keyboard.ButtonUp();
        keyboard.ButtonUp();
        keyboard.ButtonUp();
    }
        
}