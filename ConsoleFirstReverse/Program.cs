using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstReverse {
    // Суть программы: 
    // На входе вводится строка. На выходе получаем эту строку в обратно порядке.
    class Program {
        public static string FirstReverse(string str) {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--) {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
        static void Main() {
            Console.WriteLine(FirstReverse(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
