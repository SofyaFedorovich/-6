using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        { // являлется ли строка палиндромом
            {
                Console.WriteLine("Введите предложение без знаков препинания:");
                string s = Console.ReadLine().Replace(" ", "").ToLower();
                string t = s;
                string reverse = "";
                for (int i = t.Length - 1; i >= 0; i--)
                {
                    reverse += t[i];
                }
                if (t == reverse)
                {
                    Console.WriteLine("Вы ввели палиндром!");
                }
                else
                {
                    Console.WriteLine("Предложение не является палиндромом!");
                }
                Console.ReadKey();
            }
        }
    }
}
   