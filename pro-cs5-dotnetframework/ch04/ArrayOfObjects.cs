using System;

class ArrayOfObjects {
    
    public static void Main(string[] args)
    {
        Console.WriteLine("=> Array of Objects");
        
        object[] myObjects = new object[4];
        myObjects[0] = 10;
        myObjects[1] = false;
        myObjects[2] = new DateTime(1969, 3, 24);
        myObjects[3] = "Form & Void";
        foreach (object obj in myObjects)
        {
            Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
        }
        
        Console.WriteLine();

    }
}

