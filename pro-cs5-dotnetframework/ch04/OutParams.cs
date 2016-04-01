using System;

class OutParams {
    
    public static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Methods *****");
        
      // No need to assign initial value to local variables
      // used as output parameters, provided the first time
      // you use them is as output arguments.
      int ans;
      Add(90, 90, out ans);
      Console.WriteLine("90 + 90 = {0}", ans);
      Console.ReadLine();
    
        
    }
    
    static void Add(int x, int y, out int ans)
    {
        //   ans = x + y;
        ans = 12;
    }
    
    static void FillTheseValues(out int a, out string b, out bool c)
    {
      a = 9;
      b = "Enjoy your string.";
      c = true;
    }
}