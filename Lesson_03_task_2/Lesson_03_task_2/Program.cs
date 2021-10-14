using System;
using System.Collections.Generic;
//2. Реализовать метод, который в качестве входного параметра принимает строку string,
//возвращает строку типа string, буквы в которой идут в обратном порядке.
//Протестировать метод.



namespace Lesson_03_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = { "r", "wkiwu32KJ","KJas872enald","щотзцщШГр32=+"} ; //массив для теста
            for (int i = 0; i < testArray.Length; i++) //сам тест
            {
                Console.WriteLine("Строка для обработки - {0}", testArray[i]);
                Console.WriteLine("Обратная строка      - {0}", ReversWord(testArray[i]));
                Console.WriteLine("-----------------------------");
            }

            static string ReversWord(string _inputString) //метод перестановки символов в обратном порядке
            {
                int _lenght = _inputString.Length;
                string _outString = "";
                Stack<char> _stackChar = new Stack<char>();

                for (int i = 0; i < _lenght; i++) //помещаем символы строки в стек
                {
                    _stackChar.Push(_inputString[i]);
                }

                while (_stackChar.Count > 0) //вытаскиваем символы из стека, получаем обратный порядок
                {
                    _outString += _stackChar.Pop();
                }

                return _outString;
            }
        }
    }
}
