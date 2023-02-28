using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Rectangle s1 = new Rectangle("Blue", 4, 6);
        shapes.Add(s1);

        Circle s2 = new Circle("Green", 6);
        shapes.Add(s2);

        Triangle s3 = new Triangle("Pink", 3,5);
        shapes.Add(s3);

        foreach (Shape item in shapes){
            string color = item.GetColor();

            double area = item.GetArea();

            Console.WriteLine($"The color is {color} and the area is {area}");
        }
    }
}