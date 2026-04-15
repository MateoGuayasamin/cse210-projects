public class Circle : Shape
{
    private double _radius;
    public Circle(double radius, string color):base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        double area = 3.1416 * (_radius * _radius );
        return area;
    }
}