using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public enum CommandName //виды команд
    {
        dir,        // список каталогов
        mkdir,      // создание каталога
        copy,       // сопирование каталога/файла
        del,        // удаление каталога/файла
        info,       // получение информации о каталоге/файле
        file,       // просмотр содержимого файла
        quit,       // выход из программы и сохранения текущего каталога и изменнения в размере страницы вывода для команды dir
        error,      // для случая, когда введена не существующая команда
        cd,         // смена каталога
        text_info,  // информация по текстовому файлу
        chn_atr,    // изменение атрибутов
        rename      // переименование
    };
    public class Command
    {
        private CommandName _name;
        private string _argFirst;
        private string _argSecond;

        public CommandName Name { get { return _name; } }
        public string ArgFirst { get { return _argFirst; } }
        public string ArgumentSecond { get { return _argSecond; } }

        public Command(CommandName name, string argFirst, string argSecond)
        {
            _name = name;
            _argFirst = argFirst;
            _argSecond = argSecond;
        }

        public Command Parse(string commandString) //разбор команды
        {
            Command NewCommand = new (CommandName.error, "", ""); //инициализация класса

            //разбираем введенную команду на подстроки используя знак пробела как разделитель, исключая дублирование пробелов
            string[] CommandArray = commandString.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // проверка на количество аргументов, их не может быть больше 3х (команда, аргумент 1, аргумент 2) или без команды
            if (CommandArray.Length > 3 || CommandArray.Length == 0) return NewCommand;
            else if (CommandArray.Length == 2) NewCommand._argFirst = CommandArray[1];
            else if (CommandArray.Length == 3)
            {
                NewCommand._argFirst = CommandArray[1];
                NewCommand._argSecond = CommandArray[2];
            }

            switch (CommandArray[0])
            {
                case "dir":
                    NewCommand._name = CommandName.dir;
                    break;

                case "cd":
                    NewCommand._name = CommandName.cd;
                    break;

                case "copy":
                    NewCommand._name = CommandName.copy;
                    break;

                case "del":
                    NewCommand._name = CommandName.del;
                    break;

                case "file":
                    NewCommand._name = CommandName.file;
                    break;

                case "info":
                    NewCommand._name = CommandName.info;
                    break;

                case "mkdir":
                    NewCommand._name = CommandName.mkdir;
                    break;

                case "quit":
                    NewCommand._name = CommandName.quit;
                    break;

                case "text":
                    NewCommand._name = CommandName.text_info;
                    break;

                case "change":
                    NewCommand._name = CommandName.chn_atr;
                    break;

                case "rename":
                    NewCommand._name = CommandName.rename;
                    break;

                default:
                    NewCommand._name = CommandName.error;
                    break;
            }
            return NewCommand;

        }

        
    }
}
