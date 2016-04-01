using System;

class OutParams {
    
    public static void Main(string[] args)
    {
    Console.WriteLine("***** Fun with Methods *****");

  // Pass in a comma-delimited list of doubles…
  double average;
  average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
  Console.WriteLine("Average of data is: {0}", average);

  average = CalculateAverage(4.4, 5.5);
  Console.WriteLine("Average of data is: {0}", average);

    }
    
    
    // Return average of "some number" of doubles.
    static double CalculateAverage(params double[] values)
    {
      Console.WriteLine("You sent me {0} doubles.", values.Length);

      double sum = 0;
      if(values.Length == 0)
        return sum;
      for (int i = 0; i < values.Length; i++)
        sum += values[i];
      return (sum / values.Length);
    }
    
    /*
Finally, always remember that a method that defines output parameters must assign the parameter to a valid value before exiting the method scope.
Therefore, the following code will result in a compiler error, 
as the output parameter has not been assigned within the method scope:
    
    
       
    */
}