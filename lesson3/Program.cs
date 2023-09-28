using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задача 1. Программа определяет, является ли последовательность чисел упорядоченной по возрастанию.");
            Random rand = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = rand.Next(10);
                Console.Write(array[i]);
            }

            int j = 0;
            for (; j < array.Length; j++) 
            { 
                if (array[j] > array[j + 1])
                {
                    break;
                }
            
            }
            if (j < array.Length - 1)
            {
                Console.WriteLine($"\nПоследовательность не является упорядоченной по возрастанию. Первый неподходящий элемент (его порядковый номер, начиная с нуля): {j + 1}\n");
            }
            else
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            

            
            Console.WriteLine("Задача 2. Программа определяет достоинство карты по ее номеру.");
            Console.WriteLine("Введите номер карты («валет» — 11, «дамa» — 12, «король» — 13, «туз» — 14. Порядковые номера остальных карт соответствуют их названиям («шестерка», «девятка» и т.п.))");
            int card;
            try
            {
                card = int.Parse(Console.ReadLine());
                if (card < 6 ||  card > 14)
                {
                    throw new ArgumentException("Номер карты должен быть от 6 до 14\n");
                }
            }
            catch (FormatException) 
            {
                Console.WriteLine("Введите число!!!\n");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Неверный номер карты, введите число от 6 до 14.\n");
            }
            try
            {
                card = int.Parse(Console.ReadLine());
                if (card == 6)
                {
                    Console.WriteLine("Шестерка");
                }
                else if (card == 7)
                {
                    Console.WriteLine("Семёрка");
                }
                else if (card == 8)
                {
                    Console.WriteLine("Восьмерка");
                }
                else if (card == 9)
                {
                    Console.WriteLine("Девятка");
                }
                else if (card == 10)
                {
                    Console.WriteLine("Десятка");
                }
                else if (card == 11)
                {
                    Console.WriteLine("Валет");
                }
                else if (card == 12)
                {
                    Console.WriteLine("Дама");
                }
                else if (card == 13)
                {
                    Console.WriteLine("Король");
                }
                else
                {
                    Console.WriteLine("Туз");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Неизвестная ошибка");
            }
            finally
            {
                Console.ReadKey();
            }
            

            
            Console.WriteLine("Задача 3. Программа принимает на входе строку и производит выходнCые данные в соответствии с таблицей.\n");
            Console.WriteLine("Введите одно из следующих названий:\n\nJabroni\nSchool Counselor\nProgrammer\nBike Gang Member\nPolitician\nRapper\nСвой вариант");
            string x = Console.ReadLine();
            x = x.ToLower();
            switch (x)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequilla\n");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol\n");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer\n");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine\n");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars\n");
                    break;
                case "Rapper":
                    Console.WriteLine("Cristal\n");
                    break;
                default:
                    Console.WriteLine("Beer\n");
                    break;

            }
            


            Console.WriteLine("Задача 5. Программа выводит на экран, сколько кукол в сумке.");
            string[] toys = new string[] { "Hello Kitty", "Teddy Bear", "Matryoshka", "Barbie doll", "Lego" };
            int count = 0;
            for (int i = 0; i < toys.Length; i++)
            {
                Console.Write(toys[i] + "; ");
            }
            foreach (string doll in toys)
            {
                if (doll == "Hello Kitty" || doll == "Barbie doll")
                {
                    count++;
                }
            }
            Console.WriteLine("\nКоличество кукол в сумке: {0}", count);

            


        }
    }
}
