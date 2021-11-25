using System;
using ClassLibrary;

namespace star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point i = new Point(color.red, true, 4, 5);
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
            Console.WriteLine("Площадь круга " + c.Area());
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
            Console.WriteLine("Площадь прямоугольника " + s.Area());
            Console.WriteLine("Текущая координата опорной точки прямоугольника " + s.X + "  " + s.Y);
            Console.WriteLine("Передвижение фигуры вправо на 7, вниз на 4");
            s.Move(move.right, 7);
            s.Move(move.down, 4);
            Console.WriteLine("Новая координата опорной точки прямоугольника " + s.X + "  " + s.Y);
        }
    }
}
