using PatternMemento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMemento.Originator
{
    public class HeroInformation : IMemento
    {
        private int _bullets;
        private int _health;

        public HeroInformation(int bullets, int health)
        {
            _bullets = bullets;
            _health = health;
        }

        public int GetBullets()
        {
            return _bullets;
        }

        public int GetHealth()
        {
            return _health;
        }
    }
}
