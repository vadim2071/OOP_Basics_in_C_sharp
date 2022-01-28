using System;
using System.IO;

namespace ClassLibrary
{
    public abstract class FMBaseClass : IManager
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public DirectoryInfo Parent { get; set; }


        abstract public void Rename(string newName);

        abstract public void Delete();

        abstract public void MakeNew(string newName);

        abstract public void Copy(FMBaseClass newName);

        abstract public void Move(FMBaseClass newName);

        abstract public float GetSize();

        abstract public void Search(string search);
    }
}
