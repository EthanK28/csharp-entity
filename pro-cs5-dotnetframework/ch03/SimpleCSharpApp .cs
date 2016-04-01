using System;

//using System.Windows.Forms;

class TestApp
{
    static int Main(string[] args)
    {
        Console.WriteLine("***** My First C# App *****");
        Console.WriteLine("Hello World!");
        Console.WriteLine();        
        for(int i = 0; i < args.Length; i++) 
            Console.WriteLine("Arg: {0}", args[i]); 
        
        Console.ReadLine();
        
        return -1;
    }
} 