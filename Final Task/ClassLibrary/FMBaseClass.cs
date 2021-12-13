﻿using System;

namespace ClassLibrary
{
    public abstract class FMBaseClass
    {
        private string _curentPass; //текущий маршрут до объекта класса
        private string _name; //имя объекта

        public string CurentPass { get { return _curentPass; } set { _curentPass = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        public virtual void Rename(string newName)
        {

        }
        public void Delete()
        {

        }
        public void MakeNew(string newName)
        {

        }
        public void Copy(string newName)
        {

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
    }
}