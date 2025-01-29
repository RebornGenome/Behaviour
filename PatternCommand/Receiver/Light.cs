using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Receiver
{
    public class Light
    {
        private int decreaseLight = 0;
        private int increaseLight = 100;
        private int defaultLight = 50;
        private int step = 5;
        private int action;

        public Light()
        {
            action = defaultLight;
        }

        public void IncreaseLight()
        {

            if (action + step < increaseLight)
            {
                action += step;
                Console.WriteLine($"Яркость Экрана -> Увеличена {action}");
            }
            else if (action + step == increaseLight)
            {
                action += step;
                Console.WriteLine($"Яркость экрана -> Максимальная {increaseLight}");
            }
        }

        public void DecreaseLight()
        {
            if (action - step > decreaseLight)
            {
                action -= step;
                Console.WriteLine($"Яркость Экрана -> Уменьшена {action}");
            }
            else if (action - step == decreaseLight)
            {
                action -= step;
                Console.WriteLine($"Яркость экрана -> Минимальная {decreaseLight}");
            }
        }
    }
}
