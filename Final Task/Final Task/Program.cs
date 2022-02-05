using System;
using System.Text;
using ClassLibrary;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Final_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //считываем записанный ранее каталог в котором закончили работу
            CurentPath curentPath = new CurentPath();
            // переходим в сохраненный ранее каталог
            Directory.SetCurrentDirectory(curentPath.CurentPass);
            FMfolder curentFolder = new FMfolder();

            Command command = new Command(CommandName.quit, "","");

            //ждем ввода первой команды
            string InputString = Console.ReadLine();
            //разбираем команду
            command = command.Parse(InputString);
            //Основной цикл программы
            while (command.Name != CommandName.quit)
            {
                switch (command.Name)
                {
                    case CommandName.dir:
                        //
                        curentFolder.Dir(curentPath.Page);
                        break;
                    case CommandName.cd:
                        //
                        curentFolder.CDir(command.ArgFirst);
                        curentPath.Update(curentFolder);
                        break;
                    case CommandName.copy:
                        FMfolder copyFolder = new FMfolder(curentFolder + "\\" + command.ArgFirst);
                        curentFolder.Copy(copyFolder);
                        break;
                    case CommandName.del:
                        //
                        curentFolder.Delete(command.ArgFirst);

                        break;
                    case CommandName.file:

                        break;
                    case CommandName.info:

                        break;
                    case CommandName.mkdir:

                        break;
                    case CommandName.quit:
                        //сохраняем все изменения в файл конфигурации
                        curentPath.Save();
                        break;

                    case CommandName.rename:

                        break;
                    case CommandName.error:
                        Console.WriteLine("ошибка, неправильная команда");
                        break;
                }
                //ждем ввода первой команды
                InputString = Console.ReadLine();
                //разбираем команду
                command = command.Parse(InputString);
            }
           

        



        }
    }
}
