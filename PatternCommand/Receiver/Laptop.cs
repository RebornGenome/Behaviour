using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Receiver
{
    public class Laptop
    {
        public void OnLaptop()
        {
            Console.WriteLine("Запуск -> ...Ноутбук Включен!");
        }

        public void OffLaptop()
        {
            Console.WriteLine("Завершение работы -> ...Ноутбук Выключен!");
        }
    }
}
