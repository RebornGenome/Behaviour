using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMemento.Memento
{
    public interface IMemento
    {
        int GetBullets();

        int GetHealth();
    }
}
