using System;
using System.IO;

namespace ClassLibrary
{
    public abstract class FMBaseClass : IManager
    {
        public string FullPath { get; set; }
        public string NameElement { get; set; }
        public DirectoryInfo ParentElement { get; set; }


        abstract public void Rename(string newName);

        abstract public void Delete();

        abstract public void MakeNew(string newName);

        abstract public void Copy(FMBaseClass newName);

        abstract public void Move(FMBaseClass newName);

        abstract public float GetSize();

        abstract public void Search(string search);
    }
}
