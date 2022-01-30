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

        public void Dir()
        {
            //список хранения списка текущего каталога
            string[] catalog = Directory.GetDirectories(this.FullPath);
            string[] files = Directory.GetFiles(this.FullPath);
            foreach (string file in files)
            {
                catalog.Append(file);
            }




        }

        override public void Rename(string newName)
        {

        }

        override public void Delete()
        {

        }

        override public void MakeNew(string newName)
        {

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
