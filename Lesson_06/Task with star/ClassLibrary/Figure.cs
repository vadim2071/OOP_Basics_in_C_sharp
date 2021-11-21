using System;

namespace ClassLibrary
{
    public enum color { red, green, blue, white, black } // варианты цветов
    public enum move { up, down, left, right } // вид напрвлений перемещения фигуры
    public class Figure
    {
        //public enum color { red, green, blue, white, black }
        private color _color; // цвет фигуры
        private bool _visible; // состояние видимости

        public color ColorFig { get { return this._color; } set { this._color = value; } }
        public bool VisibleFig { get { return this._visible; } set { this._visible = value; } }

        public Figure(color color, bool visible)
        {
            _color = color;
            _visible = visible;
        }
        public bool Visible()
        {
            return this._visible;
        }
        public void ChangeColorTo(color color)
        {
            this._color = color;
        }
        public virtual void Move(move _move, int _step) { }
        static void PrintInfo()
        {
            Console.WriteLine("Цвет фигуры " + this._color);
            Console.WriteLine("Видимость фигуры " + this._visible);
        }
    }
}
