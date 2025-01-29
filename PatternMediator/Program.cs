using PatternMediator.Colleague;
using PatternMediator.ConcreteMediator;

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director(null);
        Programmer programmer = new Programmer(null);
        Tester tester = new Tester(null);

        Controller controller = new Controller(director, programmer, tester);

        director.ExecuteWorkDirector();
    }
}