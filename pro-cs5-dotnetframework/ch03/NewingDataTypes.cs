using System;

//using System.Windows.Forms;

class NewingDataTypes
{
    static int Main(string[] args)
    {
        Console.WriteLine("=> Using new to create variables:");
      bool b = new bool();              // Set to false.
      int i = new int();                // Set to 0.
      double d = new double();          // Set to 0.
      DateTime dt = new DateTime();     // Set to 1/1/0001 12:00:00 AM
      Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
      Console.WriteLine();
        return 0;
    }
} 