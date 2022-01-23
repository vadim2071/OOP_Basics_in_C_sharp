using System;
using System.Text;
using ClassLibrary;
using System.Collections;

namespace Final_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //Для корректного вывода псевдографики
            CurentPath Curent_Path = new CurentPath(); //считали данные о текущем маршруте и количестве строк для вывода по команде dir

            ArrayList DirList = new ArrayList(); // список каталогов и файлов
         //   string[] DirList = { }; //массив каталогов, подкаталогов и файлов после команды dir

         //   string NewString = ""; // строка новой команды на выполнение, введенной пользователем
            Command NewCommand = new(CommandName.error, "", ""); // для хранения, распознанной команда и ее аргументов


         //   cdDir(Curent_Path.CurentPass); //переходим в каталог, который был сохранен в файле конфигурации во время последнего запуска программы


            while (NewCommand.Name != CommandName.quit)
            {
                Console.WriteLine("Curent directory-> " + Curent_Path.CurentPass); // вывод текущего каталога

                NewString = Console.ReadLine(); //получение новой команды

                //подготовка к выводу результата введенной команды
                Console.Clear();                // очистка консоли
                Console.WriteLine(CurentPath);  // выводим имя текущего каталога
                Console.WriteLine(NewString);   // выводим введенную ранее команду
                NewCommand = ParseCommand(NewString); // разбираем введенную строку команды

                switch (NewCommand.Name)
                {
                    case CommandName.dir:
                        if (NewCommand.Arg1 == "") NewCommand.Arg1 = CurentPath; //если аргумента нет то выводим список каталогов в текущем каталоге
                        Array.Resize(ref DirList, 0);       // очищаем массив от предыдущих результатов
                        Dir(NewCommand.Arg1, ref DirList);  // в массив DirList записываем зодержимое каталога
                        DirPrint(ref DirList, Page);        // выводим в консоль из массива DirList список каталогов постранично
                        break;
                    case CommandName.cd:
                        cdDir(NewCommand.Arg1);
                        CurentPath = Directory.GetCurrentDirectory(); //запоминаем каталог в который перешли
                        break;
                    case CommandName.copy:
                        Copy(NewCommand.Arg1, NewCommand.Arg2);
                        break;
                    case CommandName.del:
                        Delete(NewCommand.Arg1);
                        break;
                    case CommandName.file:
                        FileInfo(NewCommand.Arg1);
                        break;
                    case CommandName.info:
                        GetInfo(NewCommand.Arg1);
                        break;
                    case CommandName.mkdir:
                        MakeDir(NewCommand.Arg1);
                        break;
                    case CommandName.quit:
                        //сохраняем все изменения в файл конфигурации
                        config.AppSettings.Settings["Path"].Value = CurentPath;
                        config.AppSettings.Settings["Page"].Value = Convert.ToString(Page);
                        config.Save(ConfigurationSaveMode.Modified);
                        break;
                    case CommandName.error:
                        Console.WriteLine("ошибка, неправильная команда");
                        break;
                }
            }

        }
    }
}
