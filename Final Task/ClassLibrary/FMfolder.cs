using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class FMfolder : FMBaseClass, IManager
    {
        public void Delete()
        {

        }

        // метод смены каталога        
        static void cdDir(string PathName)
        {
            try
            {
                if (PathName.Substring(PathName.Length - 1) != @"\") PathName += @"\";  // в строке содержащей путь последний символ должен быть \
                Directory.SetCurrentDirectory(PathName);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Ошибка! путь не найден");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Ошибка! каталог не найден");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Что-то пошло не так" + ex);
            }
        }

        //метод получения списка каталогов, подкаталогов и файлов в каталоге
        static void Dir(String PathName, ref String[] DirList)
        {
            string[] CurentDirList = { };               //для сохранения полученного списка каталогов
            string[] CurentFileList = { };              //для сохранения полученного списка файлов в текущем каталоге
            string[] Level2DirList = { };               //для хранения списка подкаталогов
            int length;
            int newPage = Page;                         // для ввода нового размера страницы вывдо списка каталогов


            if (PathName.Length == 2)                    //Проверка команды на просмотр/изменение размера выводимой страницы
            {
                if (PathName == "-p")                   //если только -p то выводим размер пейджинга
                {
                    Console.WriteLine("Текущий размер страницы вывода - {0}", Page);
                    return;
                }
            }
            else if (PathName.Length > 2)               // если аргумент содержит больше 2х символов
            {

                if (PathName.Substring(0, 2) == "-p")   // поверяем что первый 2 символа это команда -p
                {
                    try
                    {
                        newPage = Convert.ToInt32(PathName.Substring(2, PathName.Length - 2));
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Неверно введна команда");
                        return;
                    }
                    Page = newPage;
                    return;
                }
            }


            if (PathName.Substring(PathName.Length - 1) != @"\") PathName += @"\";  // в строке содержащей путь последний символ должен быть \ (необходимо если вводим имя диска без \)

            try
            {
                CurentDirList = Directory.GetDirectories(PathName);     //получаем список каталогов в каталоге PathName
            }
            catch (UnauthorizedAccessException)
            {
                Array.Resize(ref DirList, 1);                           //каталог недоступен, возвращаем список из 1 строки "Отказ в доступе"
                DirList[0] = "Отказано в доступе";
                return;
            }
            catch (DirectoryNotFoundException)
            {
                Array.Resize(ref DirList, 1);                           //каталог недоступен, возвращаем список из 1 строки "Отказ в доступе"
                DirList[0] = "такой каталог не существует";
                return;
            }
            catch (Exception ex)
            {
                Array.Resize(ref DirList, 1);                           //каталог недоступен, возвращаем список из 1 строки "Отказ в доступе"
                DirList[0] = "что-то пошло не так " + ex;
                return;
            }

            CurentFileList = Directory.GetFiles(PathName);              //получаем список файлов в каталоге PathName

            length = DirList.Length;

            for (int i = 0; i < CurentDirList.Length; i++)              //записываем список каталогов
            {
                length++;

                Array.Resize(ref DirList, length);

                if (i < CurentDirList.Length - 1) DirList[length - 1] = "\u2523\u2578" + Path.GetFileName(CurentDirList[i]);
                else DirList[length - 1] = "\u2517\u2578" + Path.GetFileName(CurentDirList[i]);

                try
                {
                    Level2DirList = Directory.GetDirectories(CurentDirList[i]);
                    for (int c = 0; c < Level2DirList.Length; c++)      //записываем список подкаталогов каждого каталога
                    {
                        length++;
                        Array.Resize(ref DirList, length);

                        string space;
                        space = i == (CurentDirList.Length - 1) ? " " : "\u2503";

                        // в зависмости от положения подкаталога в списе (последний или нет) рисуем впереди разные символы псевдографики  
                        if (c < Level2DirList.Length - 1) DirList[length - 1] = space + " \u2523\u2578" + Level2DirList[c];
                        else DirList[length - 1] = space + " \u2517\u2578" + Level2DirList[c];
                    }
                }
                catch
                {
                    length++;
                    Array.Resize(ref DirList, length);

                    string space;
                    space = i == (CurentDirList.Length - 1) ? " " : "\u2503";
                    DirList[length - 1] = space + " \u2517\u2578Отказано в доступе";
                }
            }

            for (int i = 0; i < CurentFileList.Length; i++)         // записываем список файлов 
            {
                length++;
                Array.Resize(ref DirList, length);
                DirList[length - 1] = "  " + Path.GetFileName(CurentFileList[i]);
            }
        }

        // метод вывода списка каталогов на экран
        static void DirPrint(ref String[] DirList, int Page)
        {
            ConsoleKeyInfo key;
            int lenght = DirList.Length;
            int CountPage = lenght / Page;

            for (int c = 0; c < lenght; c++)                                 //выводим все элементы массива
            {
                for (int p = 0; p < CountPage & c < Page * CountPage; p++)    //выводим страницы по очереди
                {
                    Console.Clear();
                    for (int i = 0; i < Page; i++)                          //выводим все элементы страницы
                    {
                        Console.WriteLine(DirList[(p * Page) + i]);
                    }

                    Console.WriteLine("Вывод {0}/{1}, листать - стрелка вверх/вниз, выход - q", (p + 1) * Page, lenght);
                    do
                    {
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow)               // если нажата клавиша вверх
                        {                                               // уменьшаем счетчик страниц на 1
                            p = p == 0 || p == 1 ? -1 : (p - 2);        // если это первая или вторая страница, то -1 (счетчик в цикле увеличит на 1)
                            c = p == 0 || p == 1 ? 0 : (c - Page);      // счетчик строк уменьшаем на размер страницы если эта не первая страница
                            break;
                        }
                        else if (key.Key == ConsoleKey.DownArrow)      // если нажата клавиша вниз
                        {
                            c = c + Page;                               // счетчик строк увеличиваем на размер страницы
                            break;
                        }
                        else if (key.Key == ConsoleKey.Q)               // если нажата клавиша Q
                        {
                            c = lenght;                                 // считаем что дальше ничего смотреть не будем
                        }
                    }
                    while (key.Key != ConsoleKey.Q);
                }

                if (c < lenght) Console.WriteLine(DirList[c]);          // выводим (если не нажали q) последние строки массива, количесвто которых меньше страницы
            }
        }
    }
}
