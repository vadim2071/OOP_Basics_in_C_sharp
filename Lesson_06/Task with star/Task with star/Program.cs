using System;
using ClassLibrary;

//• (*) Создать класс Figure для работы с геометрическими фигурами.
//В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое».
//Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета, опрос состояния (видимый/невидимый).
//Метод вывода на экран должен выводить состояние всех полей объекта.
//Создать класс Point (точка) как потомок геометрической фигуры. Создать класс Circle (окружность) как потомок точки.
//В класс Circle добавить метод, который вычисляет площадь окружности.
//Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.
//Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета.

namespace Task_with_star
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Point i = new Point(color.red , true, 4, 5);
            Console.WriteLine("Точка");
            i.PrintInfo();
            Console.WriteLine("Смена цвета");
            i.ChangeColorTo(color.blue);
            i.PrintInfo();

            Console.WriteLine("---------------------------------");

            Circle c = new Circle(color.white, true, 6, 7, 7);
            Console.WriteLine("Круг цвет белый, видимый");
            c.PrintInfo();
            Console.WriteLine("Смена цвета на синий");
            c.ChangeColorTo(color.blue);
            c.PrintInfo();
            Console.WriteLine("Площадь круга " + c.SquareCircle());
            Console.WriteLine("Текущая координата центра круга " + c.X + "  " + c.Y);
            Console.WriteLine("Передвижение фигуры влево на 3, вверх на 5");
            c.Move(move.up, 5);
            c.Move(move.left, 3);
            Console.WriteLine("Новая координата центра круга " + c.X + "  " + c.Y);

            Console.WriteLine("---------------------------------");

            Rectangle s = new Rectangle(color.white, false, 6, 7, 7, 5);
            Console.WriteLine("Прямоугольник цвет белый, невидимый");
            s.PrintInfo();
            Console.WriteLine("Смена цвета на красный");
            s.ChangeColorTo(color.red);
            s.PrintInfo();
            Console.WriteLine("Площадь прямоугольника " + s.SquareArea());
            Console.WriteLine("Текущая координата опорной точки прямоугольника " + s.X + "  " + s.Y);
            Console.WriteLine("Передвижение фигуры вправо на 7, вниз на 4");
            s.Move(move.right, 7);
            s.Move(move.down, 4);
            Console.WriteLine("Новая координата опорной точки прямоугольника " + s.X + "  " + s.Y);
        }
    }
}
