using PatternMediator.Colleague;
using PatternMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatternMediator.ConcreteMediator
{
    public class Controller : IMediator
    {
        private Director _director;
        private Programmer _programmer;
        private Tester _tester;

        public Controller(Director director, Programmer programmer, Tester tester)
        {
            _director = director;
            _programmer = programmer;
            _tester = tester;
            _director.SetMediator(this);
            _programmer.SetMediator(this);
            _tester.SetMediator(this);
        }

        public void Notification(string message, Employee employee)
        {
            if (employee is Director)
            {
                Console.WriteLine($"Директор отправил сообщение: {message}");
                _programmer.ExecuteWorkProgrammer();
            }
            else if (employee is Programmer)
            {
                Console.WriteLine($"Программист отправил сообщение: {message}");
                _tester.ExecuteWorkTester();
            }
            else if (employee is Tester)
            {
                Console.WriteLine($"Тестировщик отправил сообщение: {message}");
                Console.WriteLine("Проект завершен и полностью готов!");
            }
        }
    }
}
