// Virtual.cs: a test of "virtual" functions
using System;

class Shape
{
    protected string Name;

    public Shape(string name)
    {
        Name = name;
    }
    public virtual void Print() //virtual = backup
    {
        Console.WriteLine(Name);
    }
    public virtual float Area() //virtual = backup
    {
        return 0.0f;
    }
}

class Circle : Shape
{
    private float Radius;

    public Circle(string name, float r) : base(name)
    {
        Radius = r;
    }
    public override void Print() //Have to override the parent's backup
    {
        base.Print();
        Console.WriteLine("Radius = {0}", Radius);
    }
    public override float Area() //Have to override the parent's backup
    {
        // return pi*r^2
        return 3.14f * Radius * Radius;
    }
}

class Square : Shape
{
    private float EdgeLength;

    public Square(string name, float fEdgeLen) : base(name)
    {
        EdgeLength = fEdgeLen;
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine("Edge length = {0}", EdgeLength);
    }

    public override float Area()
    {
        // return length*width
        return EdgeLength * EdgeLength;
    }
}

class TestVirtualClass
{

    static void Main()
    {
        Circle cSmallBall = new Circle("mini", 1.0f);
        Circle cBeachBall = new Circle("plastic", 24.0f);
        Circle cPlanetoid = new Circle("moon", 24000.0f);

        Square sCrystal = new Square("carbon", 0.002f);
        Square sIce = new Square("party", 1.0f);
        Square sBox = new Square("cardboard", 16.0f);

        Shape[] rgShapes;

        rgShapes = new Shape[6] {
                                    cSmallBall,
                                    cBeachBall,
                                    cPlanetoid,
                                    sCrystal,
                                    sIce,
                                    sBox
                                };

        Console.WriteLine("Printed individually-----------------------------");
        cSmallBall.Print();
        cBeachBall.Print();
        cPlanetoid.Print();
        sCrystal.Print();
        sIce.Print();
        sBox.Print();


        //Code below = POLYMORPHISM
        Console.WriteLine("Printed by array-----------------------------");
        foreach (Shape s in rgShapes)
        {
            s.Print();
            Console.WriteLine("Area is {0}", s.Area());
        }
    }
}