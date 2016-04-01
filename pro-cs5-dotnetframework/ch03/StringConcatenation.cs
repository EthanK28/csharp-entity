using System;

//using System.Windows.Forms;

class StringConcatenation
{
    static int Main(string[] args)
    {
        Console.WriteLine("=> String concatenation:");
        string s1 = "Programming the ";
        string s2 = "PsychoDrill (PTP)";
        string s3 = s1 + s2;
        Console.WriteLine(s3);
        
        s3 = String.Concat(s1, s2);
        Console.WriteLine(s3);
        Console.WriteLine();        
        return 0;
    }
} 