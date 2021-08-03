using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regex22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя и фамилию: ");

            string text = Console.ReadLine();
           string pattern = (@"(^[A-Z?])[a-z]+\s([A-Z?])[a-z]+$");
            {
                if (Regex.IsMatch(text, pattern))
                {
                    Console.WriteLine("Успешно!");
                }
                else
                {
                    Console.WriteLine("Ошибка:неверный формат");
                }
            }
        }
    }
}
