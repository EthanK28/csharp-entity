using System;
using System.Collections.ObjectModel;

public class TimeOffsets
{
   public static void Main()
   {
        DateTime departure = new DateTime(2010, 6, 12, 18, 32, 0);
        DateTime arrival = new DateTime(2010, 6, 13, 22, 47, 0);
        TimeSpan travelTime = departure - arrival;  
        Console.WriteLine("{0} - {1} = {2}", arrival, departure, travelTime);    
   }


}