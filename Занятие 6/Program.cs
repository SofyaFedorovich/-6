using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_6
{
    class Program
    {
        static void Main(string[] args)
            // нахождение самого длинного слова в предложении
        {
            Console.WriteLine("Введите предложение:");
            string s = Console.ReadLine();
            string[] array = s.Split(new Char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length>index)
                {
                    index = array[i].Length;
                    max = i;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении: {0}", array[max]);
            Console.ReadKey();
        }
    }
}
