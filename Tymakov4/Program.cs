using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнения 4.1, 4.2. Программа определяет дату по введенному номеру дня в году.\n");
            Console.WriteLine("Введите номер дня в году от 1 до 365");
            int day;
            try
            {
                day = int.Parse(Console.ReadLine());
                if (day < 1 || day > 365)
                {
                    throw new ArgumentException("Значение дня должно быть от 1 до 365!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите числовое значение!");
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Значение дня должно быть от 1 до 365!");
            }
            Console.WriteLine();
        }
    }
}
