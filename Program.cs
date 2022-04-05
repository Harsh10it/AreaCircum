// See https://aka.ms/new-console-template for more information
using System;

public class Circle
{
    public static void Main()
    {


        Console.WriteLine("Input the radius of the circle : ");
        double r = Convert.ToDouble(Console.ReadLine());
        ArCircum c = new ArCircum();
        Console.WriteLine("Perimeter of Circle : {0}", c.Cal(r));

        Console.WriteLine("Area of Circle : {0}", c.Cal2(r));
    }
}
public class ArCircum
{
    double rad;

    double PI = 3.14;
    public double Cal(double r)
    {
        this.rad = r;
        return 2 * this.PI * this.rad;

    }
    public double Cal2(double r)
    {
        this.rad = r;
        return this.PI * this.rad * this.rad;
    }

}