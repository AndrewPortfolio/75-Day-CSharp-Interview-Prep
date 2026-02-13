using System;
using System.Linq;
using System.Text.RegularExpressions;

// Review 
struct Point
{
    public int X {get; set;}
    public int Y {get; set;} 

    public Point(int x, int y)
    {
        X = x;
        Y= y; 
    }
}
class Person
{
    public string fName {get;}
    public string lName {get;}

    public Person(string fN, string lN)
    {
        fName = fN;
        lName = lN;
    }
}

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    int Max(int[] arr)
    {
        int m = arr[0];
        foreach (var n in arr)
        {
            if (n > m)
            {
                m = n;
            }
        }
        return m;
    }

    static string Reverse(string s)
    {
        char[] newS = new char[s.Length]; 
        for(int i = 0; i < s.Length; i++)
        {
            newS[i] = s[s.Length-1-i];
        }
        return new string(newS);
    }

    static int CountOccurrences(string s, char target)
    {
        int count = 0;
        for(int i =0; i < s.Length; i++)
        {
            if(s[i] == target)
            {
                ++count;
            }
        }
        return count;
    }

    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> ans = new Dictionary<int, int> ();
        for(int i = 0; i < nums.Length; i++)
        {
            int b = target-nums[i];

            if (ans.ContainsKey(b))
            {
                return new int[] {ans[b], i};
            }
            ans[nums[i]] = i;
        }
        return new int[0];
    }

    static Dictionary<string, int> WordFreq(string s)
    {
        s = s.ToLower();
        s = Regex.Replace(s, @"[^\w\s]", "");
        string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> d = [];
        for(int i = 0; i < words.Length; i++)
        {
            string target = words[i];
            if(d.ContainsKey(target))
            {
                d[target] += 1;
            }
            else
            {
                d[target] = 1;
            }
        }
        return d;
    }

    static void Main()
    {
        //reference type so p1 and p2 point to the same memory 
        // if you change p2 then you also change p1
            // Person p1 = new Person("s","f");
            // Person p2 = p1;
            // Console.WriteLine($"{p1.fName} {p1.lName}");
            // Console.WriteLine($"{p2.fName} {p2.lName}");
            // p2.fName = "f";
            // p2.lName = "h";
            // Console.WriteLine($"{p1.fName} {p1.lName}");
            // Console.WriteLine($"{p2.fName} {p2.lName}");
        
        //Value types are typically seen in structs copy of val so po1 and po2
        //mihgt have the same val but don't point to same mem so changing 1 won't apply to both 
            // Point po1 = new Point(5,5);
            // Point po2 = po1;
            // po2.X = 1;
            // po2.Y = 1;
            // Console.WriteLine($"{po1.X} {po1.Y}");
            // Console.WriteLine($"{po2.X} {po2.Y}");

        int[] arr = [1,2,3,4,5,6,7,8];
        int res = Add(arr[0], arr[7]);
        for(int i = 0; i < arr.Length; i++)
        {
            if (IsEven(arr[i]))
            {
                Console.WriteLine($"{arr[i]} is even");
            }
            else
            {
                Console.WriteLine($"{arr[i]} is not even");
            }
        }

        string s = "a a a a a a a a a a What the helly!!";
        Console.WriteLine($"Reverse String: {Reverse(s)}");
        Console.WriteLine($"Letter Count: {CountOccurrences(s, 'a')}");

        int[] ans = TwoSum(arr, 10); 
        foreach (var val in ans)
        {
            Console.WriteLine($"index: {val}");    
        }

        Dictionary<string, int> f = WordFreq(s);
        
        foreach (var pair in f)
            Console.WriteLine($"Word Count: {pair}");

    }
}