using System;
//• (*) Создать класс Figure для работы с геометрическими фигурами.
//В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое».
//Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета, опрос состояния (видимый/невидимый).
//Метод вывода на экран должен выводить состояние всех полей объекта.
//Создать класс Point (точка) как потомок геометрической фигуры. Создать класс Circle (окружность) как потомок точки.
//В класс Circle добавить метод, который вычисляет площадь окружности.
//Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.
//Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета.

namespace Library
{
    public enum color { red, green, blue, white, black }
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
        public void ChangeColorTo (color color)
        {
            this._color = color;
        }
        public abstract void MoveHorizont(int move);

        public void MoveVertikal(int move)
        {

        }
        public void PrintInfo()
        {
            Console.WriteLine("Цвет фигуры " + this._color);
            Console.WriteLine("Видимость фигуры " + this._visible);
        }
    }
}
