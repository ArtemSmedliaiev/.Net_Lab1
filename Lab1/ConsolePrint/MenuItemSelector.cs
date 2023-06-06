using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.ConsolePrint
{
    internal class MenuItemSelector
    {
        private readonly int _minValue;
        private readonly int _maxValue;

        public MenuItemSelector(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public int SelectItem()
        {
            while (true)
            {
                Console.Write("\nОберіть пункт: ");
                string? readValue = Console.ReadLine();
                if (!IsConvertableToInt32(readValue))
                {
                    Console.WriteLine("Ви ввели не цілочислене значення\nСпробуйте знов");
                    continue;
                }

                int value = Convert.ToInt32(readValue);

                if (value < _minValue || value > _maxValue)
                {
                    Console.WriteLine("Ви обрали пункт, якого не має у меню\nСпробуйте знов");
                    continue;
                }
                return value - 1;
            }
        }

        private bool IsConvertableToInt32(string? readValue)
        {
            if (readValue is null)
                return false;
            try
            {
                Convert.ToInt32(readValue);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }
    }
}
