using System;

//using System.Windows.Forms;

class StringInterpolation
{
    static int Main(string[] args)
    {

// Some local variables we will plug into our larger string
    int age = 4;
    string name = "Soren";

    // Using curly bracket syntax.
    string greeting = string.Format("Hello {0} you are {1} years old.", name, age);

    // Using string interpolation
    var greeting2 = $"Hello {name} you are {age} years old.";
    Console.WriteLine(greeting2);         
        return 0;
    }
} 