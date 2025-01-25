using PatternChainOfResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility
{
    public class Client
    {
        public static void ClientPart(AbstractSoldier soldier)
        {
            List<string> listAction = new List<string>()
            {
                "Выстрелил со Снайперской Винтовки",
                "Перебинтовала солдата",
                "Разминировал мины",
                "Поставила укол"
            };

            foreach (var action in listAction)
            {
                var resultAction = soldier.GetCommand(action);
                
                if (resultAction != null)
                {
                    Console.WriteLine(resultAction);
                }
                else
                {
                    Console.WriteLine($"Команда -> ({action}) НИ кем НЕ Выполняется!");
                }
            }
        }
    }
}
