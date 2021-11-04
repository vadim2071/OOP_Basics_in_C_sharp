using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

//3. * Работа со строками.
//Дан текстовый файл, содержащий ФИО и e-mail адрес.

//Разделителем между ФИО и адресом электронной почты является символ &:
//Кучма Андрей Витальевич & Kuchma@mail.ru
//Мизинцев Павел Николаевич & Pasha@mail.ru

//Сформировать новый файл, содержащий список адресов электронной почты.
//Предусмотреть метод, выделяющий из строки адрес почты.

//Методу в качестве параметра передается символьная строка s,
//e-mail возвращается в той же строке s:
//public void SearchMail (ref string s).

namespace Lesson_03_task_3dop
{
    class Program
    {
        static void Main(string[] args)
        {
            //массив для тестов
            string[] testArray = {  "Кучма Андрей Витальевич &Kuchma@mail.ru", 
                                    "Мизинцев Павел Николаевич & Pasha@mail.ru  ", 
                                    "Иванов Иван Иванович &    ivan@.mail.ru", 
                                    "Петров Петр Петрович & p.petrov@mail.ru",
                                    "Сидоров Иван Петрови&i.sidorovmail.ru",
                                    "Феофанов Авросий Батькович&  a.feofanov@mailru",
                                    "Гаврилов Гаврил Семенович & g.gavrilov@u.r"};
            string FilePass = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\"; // путь для сохранения файла
            string filename = "test.txt"; //имя файла для записи
            File.WriteAllText(FilePass + filename, testArray[0]); // создаем / очищаем существующий файл для записи дерева
            for (int i = 1; i < testArray.Length; i++)  //записали тест в файл на рабочем столе с названием test.txt
            {
                File.AppendAllText(FilePass + filename, Environment.NewLine);
                File.AppendAllText(FilePass + filename, testArray[i]);
            }

            //вывод списка электронной почты из файла
            StreamReader _file = new StreamReader(FilePass + filename);
            string _string;
            while (!_file.EndOfStream)
            {
                _string = _file.ReadLine();
                Console.WriteLine(_string);
                SearchMail(ref _string);
                Console.WriteLine("Адрес электронной почты - {0}\n", _string);
            }

            static void SearchMail (ref string s)
            {
                int _index;
                string _string;
                _index = s.IndexOf("&"); //ищем позицию разделитель
                s = s.Substring(_index + 1);

                //проверка на наличие лишних пробелов после разделителя и удаление их
                while (s.IndexOf(" ") == 0)
                {
                    s = s.Substring(1);
                }
                //простая проверка на соответствие строки электронной почте. Проверяю на наличие знаков @ и .

                _index = s.IndexOf("@");
                // Если @ написан в начале строки или после него 3 символа (не хватит на имя домена и имя зоны) или нет символа @
                if ((_index <= 0) || (_index >= s.Length-4) )
                {
                    s = "Ошибка в написании адреса электроной почты - " + s;
                    return;
                }
                _string = s.Substring(_index + 1);

                //Теперь проверяем положении точки, так как у на супрщенная проверка не учитываем то что в адресе может быть имя домена и поддомена
                _index = _string.IndexOf(".");

                //если точка стоит сразу после @ или после точки один символ или точки совсем нет
                if ((_index <= 0) || (_index >= _string.Length - 1))
                {
                    s = "Ошибка в написании адреса электроной почты - " + s;
                    return;
                }
            }
        }
    }
}
