using System;

//using System.Windows.Forms;

class StringsAreImmutable2
{
    static int Main(string[] args)
    {

        // Set initial string value.
          string s1 = "This is my string.";
          Console.WriteLine("s1 = {0}", s1);

          // Uppercase s1?
          string upperString = s1.ToUpper();
          Console.WriteLine("upperString = {0}", upperString);

          // Nope! s1 is in the same format!
          Console.WriteLine("s1 = {0}", s1);
        return 0;
    }
} 