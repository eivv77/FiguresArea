using FiguresArea;

Console.WriteLine("введите название фигуры");
string fName =  Console.ReadLine();

if (fName == "круг")
{
    Console.WriteLine("введите радиус круга");
    double radius = Convert.ToDouble(Console.ReadLine());

    Circle circle = new Circle(fName, radius);
    Console.WriteLine("площадь " + fName + "а" + " " + circle.GetArea());
}
else if (fName == "треугольник")
{
    Console.WriteLine("введите стороны треугольника ");
    double xy = Convert.ToDouble(Console.ReadLine());
    double yz = Convert.ToDouble(Console.ReadLine());
    double xz = Convert.ToDouble(Console.ReadLine());

    Triangle triangle = new Triangle(fName, xy, yz, xz);
    Console.WriteLine("площадь " + fName + "а" + " " + triangle.GetArea());
    Console.WriteLine("является прямоугольным? " + triangle.IsPramouqolniy());
}
else 
{
    Console.WriteLine("нет такой фигуры, возможно вычисление площади только данных фигур: круг , треугольник");
}


