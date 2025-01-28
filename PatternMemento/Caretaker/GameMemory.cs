using PatternMemento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMemento.Caretaker
{
    public class GameMemory
    {
        private List<IMemento> mementoHistory;
        private ChangeInformationHero _changeInformationHero;

        public GameMemory(ChangeInformationHero changeInformationHero)
        {
            _changeInformationHero = changeInformationHero;
            mementoHistory = new List<IMemento>();
        }

        public void Backup()
        {
            mementoHistory.Add(_changeInformationHero.SaveInformation());
        }

        public void ShowAllSaveMemento()
        {
            if (mementoHistory.Count > 0)
            {
                for (int i = 0; i < mementoHistory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Сохранение №{i + 1}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Доступных Сохранений нет!");
                return;
            }
        }

        public bool IsSaveMemento(int index)
        {
            return index >= 0 && index <= mementoHistory.Count;
        }

        public void CheckMemento(int index)
        {
            _changeInformationHero.RestoreInformation(mementoHistory[index - 1]);
            Console.WriteLine($"\nСохранение {index} загружено!");
        }
    }
}
