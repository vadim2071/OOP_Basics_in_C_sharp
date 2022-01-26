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

        
    }
}
