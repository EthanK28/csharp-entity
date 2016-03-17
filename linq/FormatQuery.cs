using System;
using System.Collections.Generic;
using System.Linq;

class FormatQuery
{
    static void Main()
    {
        // Data Source.
        double[] radii = { 1, 2, 3};
        
        // Query.
        IEnumerable<string> query = 
            from rad in radii
            select String.Format("Area = {0}", (rad * rad) * 3.14);
            
            foreach (string s in query)
                Console.WriteLine(s);
            
            // Keep the console open in debug mode
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        
            
    }
}