using System;
using System.IO;

namespace ClassLibrary
{
    public abstract class FMBaseClass
    {
        private string _curentPass; //текущий маршрут до объекта класса
        private string _name; //имя объекта

        public string CurentPass { get { return _curentPass; } set { _curentPass = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        public void Rename(string newName)
        {

        }
        public void Delete(string DelElement)
        {
            //если второй символ не ':' (используется в обозначени диска),
            //предполагаем что DelElement содержит имя удаляемого элемента в текущем каталоге
            if (DelElement[1] != ':') DelElement = Path.Combine(Directory.GetCurrentDirectory(), DelElement);

            try
            {
                if (File.Exists(DelElement))
                {
                    File.Delete(DelElement);
                    return;
                }
                else if (Directory.Exists(DelElement))
                {
                    Directory.Delete(DelElement, true);
                    return;
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ошибка! У вас нет прав на удаление этого объекта");
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка! Файл используется другим процессом или файл не найден");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ошибка в аргументе");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("параметр задан в недопустимом формате");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! Что-то пошло не так: " + ex);
            }

            try
            {
                Directory.Delete(DelElement);
                return;
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ошибка! У вас нет прав на удаление этого объекта");
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка! В каталоге файл используется другим процессом или каталог не найден \nили каталог доступен только для чтения или содержит файл только для чтения");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ошибка в аргументе");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("параметр задан в недопустимом формате");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! Что-то пошло не так: " + ex);
            }
        }
        public void MakeNew(string NewDir)
        {
            try
            {
                //если аргумент не содержит знаки : (используется при обозначении пути к диску)
                //предполагаем что NewDir это имя нового каталога в текущем каталоге
                if (NewDir.Substring(1, 2) != ":") NewDir = Path.Combine(Directory.GetCurrentDirectory(), NewDir);

                if (Directory.Exists(NewDir)) Console.WriteLine("Каталог уже существует");
                else Directory.CreateDirectory(NewDir);
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка! Каталог, заданный параметром path, является файлом или недопустимый путь");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ошибка! отсутствует необходимое разрешение");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Ошибка! не задан новый католог");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Что-то пошло не так {0}", ex);
            }
        }
        public void Copy(string PathFrom, string PathTo)
        {
            if (PathFrom == PathTo)
            {
                Console.WriteLine("Ошибка! Нельзя копировать файл или каталог в самого себя");
                return;
            }

            if (File.Exists(PathFrom))
            {
                try
                {
                    File.Copy(PathFrom, PathTo, true);
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Каталог не найден");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Что-то пошло не так " + ex);
                }
            }
            else if (Directory.Exists(PathFrom))
            {
                DirCopy(PathFrom, PathTo);
            }
            else Console.WriteLine("Ошибка! Неверно указан источник копирования");
        }
        public void Move(string newName)
        {

        }
        public float GetSize()
        {
            return 0;
        }
        public void Search(string search)
        {

        }
        public void ChangeAttribute(string attribite, string newAttribute)
        {

        }

        // Метод копирования каталога            
        static void DirCopy(string PathFrom, string PathTo)
        {
            DirectoryInfo DirPathSource = new DirectoryInfo(PathFrom);
            DirectoryInfo DirPathDestination = new DirectoryInfo(PathTo);
            DirectoryInfo[] DirList = DirPathSource.GetDirectories();       //получаем список каталогов в копируемом каталоге
            FileInfo[] FileList = DirPathSource.GetFiles();                 // получаем список файлов в копируемом каталоге

            try
            {
                Directory.CreateDirectory(PathTo);          // создание целевого каталога
                foreach (FileInfo file in FileList) file.CopyTo(Path.Combine(DirPathDestination.FullName, file.Name));              //копируем все файлы
                foreach (DirectoryInfo Dir in DirList) DirCopy(Dir.FullName, Path.Combine(DirPathDestination.FullName, Dir.Name));  //создаем все существующией каталоги в целевом каталоге
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка! каталог в который копируется является файлом или недопустимый путь");
                return;
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ошибка! У вас нет прав для копирования");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Что-то пошло не так" + ex);
                return;
            }
        }
    }
}
