using System;
using ClassLibrary;

namespace Lesson07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Test = "Проверка кодирования Testing";
            Console.WriteLine("Исходная строка - " + Test);
            Test = ACoder.Encoder(Test);
            Console.WriteLine("Зашифрованная строка  (сдвиг на один символ) - " + Test);
            Test = ACoder.Decoder(Test);
            Console.WriteLine("Расшифрованная строка (сдвиг на один символ) - " + Test);

            Console.WriteLine();

            Test = "Проверка кодирования";
            Console.WriteLine("Исходная строка - " + Test);
            Test = BCoder.Encoder(Test);
            Console.WriteLine("Зашифрованная строка   - " + Test);
            Test = BCoder.Decoder(Test);
            Console.WriteLine("Расшифрованная строка  - " + Test);

        }
    }
}
