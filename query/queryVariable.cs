using System;
using System.Linq;
using System.Collections.Generic;

class queryVariable
{
    static void Main()
    {
        
        // Data source.
        int[] scores = { 90, 71, 82, 93, 75, 82 };

        // Query Expression.
        IEnumerable<int> scoreQuery = //query variable
            from score in scores //required
            where score > 80 // optional
            orderby score ascending // optional
            select score; //must end with select or group

        // Execute the query to produce the results
        foreach (int testScore in scoreQuery)
        {
            Console.WriteLine(testScore);
        }    
    }
        IEnumerable<int> scoreQuery =
        from score in scores
        select score;

        int highScore = scoreQuery.Max();
}