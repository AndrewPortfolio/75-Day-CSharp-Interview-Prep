using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("steve", "loser");
        Person p2 = new Person("steven", "winner");
        Console.WriteLine($"Person 1: {p1.GetFullName()} Person 2: {p2.GetFullName()}");

        p1.FirstName = "Andrew";
        p1.LastName = "Dude";
        p2.FirstName = "Diddy";
        p2.LastName = "Sean";
        Console.WriteLine($"Person 1: {p1.GetFullName()} Person 2: {p2.GetFullName()}");

        Point po1 = new Point(1, 2);
        Point po2 = new Point(6, 7);
        Console.WriteLine($"Point 1: ({po1.X},{po1.Y}) Point 2: ({po2.X},{po2.Y})");
        Console.WriteLine($"Point 1: ({po1.X = 5},{po1.Y = 5}) Point 2: ({po2.X = 4},{po2.Y = 5})");

        // test to see what I can do with nulls 
        // string name = null;
        // int? x = null;
        // Console.WriteLine(name);
        // Console.WriteLine(x);
        string text = "    a a a a a !!!!! Hi hi hello HELLO hi";
        Dictionary<string, int> ans = WordFrequency(text);

        foreach (var pair in ans)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
       
    }
    static Dictionary<string, int> WordFrequency(string text)
    {
        text = text.ToLower();
        text = Regex.Replace(text, @"[^\w\s]", "");
        string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> d = [];
        for (int i = 0; i < words.Length; i++)
        {
            string targetWord = words[i];
            if (d.ContainsKey(targetWord))
            {
                d[targetWord] += 1;
            }
            else
            {
                d[targetWord] = 1;
            }
        }

        return d;
    }
}
