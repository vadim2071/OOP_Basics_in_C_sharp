using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal interface IManager
    {
        public void Rename(string newName);
        public void Delete();
        public void MakeNew(string newName);
        public void Copy(string newName);
        public void Move(string newName);
        public float GetSize();
        public void Search(string search);
        public void ChangeAttribute(string attribite, string newAttribute);

    }
}
