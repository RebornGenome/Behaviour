using PatternMemento.Caretaker;
using PatternMemento.Memento;

class Program
{
    static void Main(string[] args)
    {

        ChangeInformationHero changeInformationHero = new ChangeInformationHero(35, 100);
        GameMemory gameMemory = new GameMemory(changeInformationHero);

        Console.WriteLine(new string('*', 25) + " Игра Началась " + new string('*', 25));

        changeInformationHero.GetBullets();
        changeInformationHero.GetHealth();

        while (true)
        {
            Console.Write("\nВведите количество выпущенных пуль: ");
            string shotBullet = Console.ReadLine();
            if (!int.TryParse(shotBullet, out int shot) || shot < 0 || shot > 35)
            {
                Console.WriteLine("Ошибка: Был осуществлен не корректный ввод данных! Повторите попытку.");
            }
            else
            {
                for (int i = 0; i < shot; i++)
                {
                    changeInformationHero.Shoot();
                }
                break;
            }
        }

        changeInformationHero.GetBullets();
        changeInformationHero.GetHealth();

        Console.WriteLine("\n" + new string('-', 10) + " По Вам выстрелили " + new string('-', 10));

        changeInformationHero.DecreaseHealth();
        changeInformationHero.GetBullets();
        changeInformationHero.GetHealth();

        if (changeInformationHero.GetHP() <= 0)
        {
            Console.WriteLine("\n" + new string('=', 10) + " Загружаем Сохранение... " + new string('=', 10));
            gameMemory.ShowAllSaveMemento();
            Console.WriteLine(new string('*', 25) + " Игра Окончена " + new string('*', 25));
            return;
        }

        Console.WriteLine("\n" + new string('+', 10) + " Авто Сохранение Игры " + new string('+', 10));
        gameMemory.Backup();

        while (true)
        {
            Console.Write("\nВведите количество выпущенных пуль: ");
            string shotBullet = Console.ReadLine();
            if (!int.TryParse(shotBullet, out int shot) || shot < 0)
            {
                Console.WriteLine("Ошибка: Был осуществлен не корректный ввод данных! Повторите попытку.");
            }
            else
            {
                for (int i = 0; i < shot; i++)
                {
                    changeInformationHero.Shoot();
                }
                break;
            }
        }

        changeInformationHero.GetBullets();
        changeInformationHero.GetHealth();

        Console.WriteLine("\n" + new string('-', 10) + " По Вам выстрелили " + new string('-', 10));

        changeInformationHero.DecreaseHealth();
        changeInformationHero.GetBullets();
        changeInformationHero.GetHealth();

        if (changeInformationHero.GetHP() <= 0)
        {
            Console.WriteLine("\n" + new string('=', 10) + " Загружаем Сохранение... " + new string('=', 10));
            gameMemory.ShowAllSaveMemento();
            while (true)
            {
                Console.Write("Введите номер доступного Сохранения: ");
                string choice = Console.ReadLine();
                if (!int.TryParse(choice, out int choiceSave))
                {
                    Console.WriteLine("Ошибка: Был осуществлен не корректный ввод данных! Повторите попытку.");
                }
                else
                {
                    if (!gameMemory.IsSaveMemento(choiceSave))
                    {
                        Console.WriteLine("Ошибка: Был введен несуществующий номер сохранения!");
                    }
                    else
                    {
                        gameMemory.CheckMemento(choiceSave);
                        changeInformationHero.GetBullets();
                        changeInformationHero.GetHealth();
                        break;
                    }
                }
            }
            Console.WriteLine(new string('*', 25) + " Игра Окончена " + new string('*', 25));
            return;
        }

        Console.WriteLine("\n" + new string('+', 10) + " Авто Сохранение Игры " + new string('+', 10));
        gameMemory.Backup();

        while (true)
        {
            Console.Write("\nВведите количество выпущенных пуль: ");
            string shotBullet = Console.ReadLine();
            if (!int.TryParse(shotBullet, out int shot) || shot < 0)
            {
                Console.WriteLine("Ошибка: Был осуществлен не корректный ввод данных! Повторите попытку.");
            }
            else
            {
                for (int i = 0; i < shot; i++)
                {
                    changeInformationHero.Shoot();
                }
                break;
            }
        }

        changeInformationHero.GetBullets();
        changeInformationHero.GetHealth();

        Console.WriteLine("\n" + new string('-', 10) + " По Вам выстрелили " + new string('-', 10));

        changeInformationHero.DecreaseHealth();
        changeInformationHero.GetBullets();
        changeInformationHero.GetHealth();

        Console.WriteLine("\n" + new string('=', 10) + " Загружаем Сохранение... " + new string('=', 10));
        gameMemory.ShowAllSaveMemento();
        while (true)
        {
            Console.Write("Введите номер доступного Сохранения: ");
            string choice = Console.ReadLine();
            if (!int.TryParse(choice, out int choiceSave))
            {
                Console.WriteLine("Ошибка: Был осуществлен не корректный ввод данных! Повторите попытку.");
            }
            else
            {
                if (!gameMemory.IsSaveMemento(choiceSave))
                {
                    Console.WriteLine("Ошибка: Был введен несуществующий номер сохранения!");
                }
                else
                {
                    gameMemory.CheckMemento(choiceSave);
                    changeInformationHero.GetBullets();
                    changeInformationHero.GetHealth();
                    break;
                }
            }
        }
        Console.WriteLine(new string('*', 25) + " Игра Окончена " + new string('*', 25));
    }
}