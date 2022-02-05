using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace ClassLibrary
{
    public class CurentPath //хранение, чтение, запись информации о последнем каталоге и количестве страниц для показа каталога 
    {
        private string _curent_path = Directory.GetCurrentDirectory(); // текущий каталог
        private int _page = 25; //сколько строк выводить за 1 раз при команде dir, значение по умолчанию - 25 если нет файла конфигурации, нужна видимость в методе dir

        public string CurentPass { get { return _curent_path; } set { _curent_path = value; } }
        public int Page { get { return _page; } set { _page = value; } }

        public CurentPath()
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            var FileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile.FilePath };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(FileMap, ConfigurationUserLevel.None);

            if (File.Exists(FileMap.ExeConfigFilename))  // проверяем наличие файла конфигурации
            {
                _curent_path = config.AppSettings.Settings["Path"].Value;
                _page = Convert.ToInt32(config.AppSettings.Settings["Page"].Value);
                //проверяем существование сохраненного каталога, если он есть то сохраняем его как текущий каталог иначе начинаем с рабочего каталога программы
                if (!Directory.Exists(_curent_path)) _curent_path = Directory.GetCurrentDirectory();
            }
            else
            {
                config.AppSettings.Settings.Add("Path", _curent_path);
                config.AppSettings.Settings.Add("Page", Convert.ToString(_page));
                config.Save();
            }
        }
        public void Save()
        {
            _curent_path = Directory.GetCurrentDirectory(); // текущий каталог
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            var FileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile.FilePath };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(FileMap, ConfigurationUserLevel.None);
            //сохраняем все изменения в файл конфигурации
            config.AppSettings.Settings["Path"].Value = _curent_path;
            config.AppSettings.Settings["Page"].Value = Convert.ToString(_page);
            config.Save(ConfigurationSaveMode.Modified);
        }
        public void Update(FMfolder path)
        {
            _curent_path = Directory.GetCurrentDirectory(); // текущий каталог
            path.FullPath = _curent_path;
            path.NameElement = Path.GetFileName(_curent_path);
            path.ParentElement = Directory.GetParent(_curent_path);
        }
    }
}
