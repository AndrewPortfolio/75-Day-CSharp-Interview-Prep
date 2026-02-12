using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

struct Point
{
    public int X;
    public int Y;
}

class Names
{
    public string fName;
    public string lName;
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        int x = 1; 
        int y = 5;

        p1.X = x; 
        p1.Y = y;
        Point p2 = p1;

        Names n1 = new Names();
        Names n2 = new Names(); 

        string Name1 = "David";
        string Name2 = "Lee";

        n1.lName = Name1;
        n1.fName = Name2; 
        n2.lName = Name2;
        n2.fName = Name1;

        if (p1.X == p2.X && p1.Y == p2.Y)
        {
            Console.WriteLine($"Person 1: {n1.fName} {n1.lName} and Person 2: {n2.fName} {n2.lName} are in the same location at X:{p1.X} Y:{p1.Y}");
        }

        double x2 = 1.1;
        double x3 = 6.7; 
        x3 = x2 + x3;

        Console.WriteLine(x3);

        string s = "Dude what";
        string s1 = "are you doing";

        Console.WriteLine(s + s1);
        Console.WriteLine($"{s + s1}");
        Console.WriteLine($"{s} {s1}");

    }
}