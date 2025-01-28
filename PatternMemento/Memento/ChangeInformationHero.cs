using PatternMemento.Originator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMemento.Memento
{
    public class ChangeInformationHero
    {
        private int _bullets;
        private int _health;
        private int _hit = 33;

        public ChangeInformationHero(int bullets, int health)
        {
            _bullets = bullets;
            _health = health;
        }

        public void GetBullets()
        {
            Console.WriteLine($"Патронов -> {_bullets}");
        }

        public void GetHealth()
        {
            Console.WriteLine($"Здоровье -> {_health}");
        }

        public void Shoot()
        {
            if (_bullets > 0)
            {
                _bullets--;
            }
            else
            {
                Console.WriteLine("\nВнимание: Закончились патроны!\n");
                return;
            }
        }
        
        public void DecreaseHealth()
        {
            if (_health > 0 && _health > _hit)
            {
                _health -= _hit;
            }
            else
            {
                _health = 0;
                Console.WriteLine("\nВнимание: Здоровье закончилось, вас убили!\n");
                return;
            }
        }

        public int GetHP()
        {
            return _health;
        }

        public HeroInformation SaveInformation()
        {
            return new HeroInformation(_bullets, _health); 
        }

        public void RestoreInformation(IMemento mementoChange)
        {
            _bullets = mementoChange.GetBullets();
            _health = mementoChange.GetHealth();
        }
    }
}
