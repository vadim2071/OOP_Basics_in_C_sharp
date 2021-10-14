using System;
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
            string[] testArray = { "Кучма Андрей Витальевич & Kuchma@mail.ru", "Мизинцев Павел Николаевич & Pasha@mail.ru  ", "Иванов Иван Иванович &    ivan@.mail.ru", "Петров Петр Петрович & p.petrov@mail.ru"};
            string FilePass = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\"; // путь для сохранения файла
            string filename = "test.txt"; //имя файла для записи
            File.WriteAllText(FilePass + filename, testArray[0]); // создаем / очищаем существующий файл для записи дерева
            for (int i = 1; i < testArray.Length; i++)  //записали тест в файл на рабочем столе с названием test.txt
            {
                File.AppendAllText(FilePass + filename, Environment.NewLine);
                File.AppendAllText(FilePass + filename, testArray[i]);
            }
            //вывод списка из файла
            while (File(FilePass + filename))


            static void SearchMail (ref string s)
            {

            }
        }
    }
}
