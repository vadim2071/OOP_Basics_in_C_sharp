using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class FMfolder : FMBaseClass
    {
        public FMfolder()
        {
            
            FullPath = Directory.GetCurrentDirectory();
            NameElement = Path.GetFileName(FullPath);
            ParentElement = Directory.GetParent(FullPath);
        }

        public void Dir(int page)
        {
            //список хранения списка текущего каталога
            string[] catalog = Directory.GetDirectories(this.FullPath);
            string[] files = Directory.GetFiles(this.FullPath);
            catalog = catalog.Concat(files).ToArray();
            Console.WriteLine(this.FullPath);
 
            for (int i = 0; i < catalog.Length; i++)
            {
                for (int n = 0; n < page & i < catalog.Length; n++)
                {
                    Console.WriteLine(Path.GetFileName(catalog[i]));
                    i++;
                }

                if (i < catalog.Length)
                {
                    Console.WriteLine("->For next page press ENTER");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("->This page last");
        }

        public void CDir(string newPath)
        {
            try
            {
                if (newPath.Substring(newPath.Length - 1) != @"\") newPath += @"\";  // в строке содержащей путь последний символ должен быть \
                Directory.SetCurrentDirectory(newPath);
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

        override public void Rename(string newName)
        {

        }

        override public void Delete(string delName)
        {
            try
            {
                Directory.Delete(this.FullPath + delName, true);
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

        override public void MakeNew(string newDir)
        {
            try
            {
                if (Directory.Exists(this.FullPath + "\\" + newDir)) Console.WriteLine("Каталог уже существует");
                else Directory.CreateDirectory(newDir);
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

        override public void Copy(FMBaseClass newName)
        {

        }

        override public void Move(FMBaseClass newName)
        {

        }

        override public float GetSize()
        {
            return 0;
        }

        override public void Search(string search)
        {

        }


    }
}
