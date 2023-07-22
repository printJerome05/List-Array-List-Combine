using System;
using System.Collections.Generic;
using System.Linq;
public class program123
{

    public static void Main(string[] args)
    {
       

        List<string> ls = new List<string>();
        ls.Add("Circles");
        ls.Add("Ride Slow");
        ls.Add("Ikaw Lang");
        ls.Add("Stay");
        ls.Add("Dance With You");
        List<string> ls1 = new List<string>();
        ls1.Add("Post Malone");
        ls1.Add("Russ");
        ls1.Add("Kiyo");
        ls1.Add("Justin Bieber");
        ls1.Add("Skusta Clee");

        Console.WriteLine("Songs: ");
        foreach (string l in ls)
        {
            Console.WriteLine(l);
        }
       
        Console.WriteLine("****************");
        Console.WriteLine("Artist: ");
        foreach (string l1 in ls1)
        {
            Console.WriteLine(l1);
        }
        
        Console.WriteLine("****************");
        Console.WriteLine("PlayList: ");
        var newList = ls.Zip(ls1, (s, i) => new { sv = s, iv = i }).ToList();
        foreach (var x in newList)
        {
            Console.WriteLine("{0}, {1}", x.sv, x.iv);
        }

    
        
    }
}