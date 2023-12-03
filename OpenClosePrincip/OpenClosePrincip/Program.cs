namespace OpenClosePrincip;

public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Circle is Drawing");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Rectangle is Drawing.");
    }
}

public class Drawer
{
    public void DrawShape(Shape shape)
    {
        shape.Draw();
    }
}

class Program
{
    static void Main()
    {
        Drawer drawer = new Drawer();

        Shape circle = new Circle();
        drawer.DrawShape(circle);

        Shape rectangle = new Rectangle();
        drawer.DrawShape(rectangle);
    }
}
