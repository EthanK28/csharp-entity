using System;

class SimpleArray {
    
    public static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Methods *****");
        
        SimpleArrays();
        Console.ReadLine();

    }
    
    static void SimpleArrays()
    {
        Console.WriteLine("=> Simple Array Creation");
        int[] myInts = new int[3];
        myInts[0] = 100;
        myInts[1] = 200;
        myInts[2] = 300;
        
        string[] booksOnDotNet = new string[100];
        
        foreach (int i in myInts)
            Console.WriteLine(i);
            
        Console.WriteLine();
        
    }
}