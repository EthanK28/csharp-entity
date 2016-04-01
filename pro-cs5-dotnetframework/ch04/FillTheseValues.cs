using System;

class OutParams {
    
    public static void Main(string[] args)
    {
    
    int i; string str; bool b;
  FillTheseValues(out i, out str, out b);

  Console.WriteLine("Int is: {0}", i);
  Console.WriteLine("String is: {0}", str);
  Console.WriteLine("Boolean is: {0}", b);
  Console.ReadLine();
        
    }

    static void FillTheseValues(out int a, out string b, out bool c)
    {
      a = 9;
      b = "Enjoy your string.";
      c = true;
    }
    
    /*
Finally, always remember that a method that defines output parameters must assign the parameter to a valid value before exiting the method scope.
Therefore, the following code will result in a compiler error, 
as the output parameter has not been assigned within the method scope:
    
    
       
    */
}