using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal interface IManager
    {
        abstract public void Rename(string newName);
        abstract public void Delete();
        abstract public void MakeNew(string newName);
        abstract public void Copy(FMBaseClass newName);
        abstract public void Move(FMBaseClass newName);
        abstract public float GetSize();
        abstract public void Search(string search);
    //public void ChangeAttribute(string attribite, string newAttribute);

    }
}
