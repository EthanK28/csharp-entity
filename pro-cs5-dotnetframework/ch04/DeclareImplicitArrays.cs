using System;

class DeclareImplicitArrays {
    
    public static void Main(string[] args)
    {
        
    Console.WriteLine("=> Implicit Array Initialization.");

      // a is really int[].
      var a = new[] { 1, 10, 100, 1000 };
      Console.WriteLine("a is a: {0}", a.ToString());

      // b is really double[].
      var b = new[] { 1, 1.5, 2, 2.5 };
      Console.WriteLine("b is a: {0}", b.ToString());

      // c is really string[].
      var c = new[] { "hello", null, "world" };
      Console.WriteLine("c is a: {0}", c.ToString());
      Console.WriteLine();
                
    }


}