using System;

class EnterLogData {
    
    public static void Main(string[] args)
    {
    
    Console.WriteLine("***** Fun with Methods *****");

      EnterLogData("Oh no! Grid can’t find data");
      EnterLogData("Oh no! I can’t find the payroll data", "CFO");

      Console.ReadLine();
            
    }

    static void EnterLogData(string message, string owner = "Programmer")
    {
      Console.Beep();
      Console.WriteLine("Error: {0}", message);
      Console.WriteLine("Owner of Error: {0}", owner);
    }
    
    /*
Finally, always remember that a method that defines output parameters must assign the parameter to a valid value before exiting the method scope.
Therefore, the following code will result in a compiler error, 
as the output parameter has not been assigned within the method scope:
    
    
       
    */
}