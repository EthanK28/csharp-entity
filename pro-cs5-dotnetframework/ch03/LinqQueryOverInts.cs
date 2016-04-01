using System;
using System.Text;
using System.Linq;


//using System.Windows.Forms;

class LinqQueryOverInts
{
    static int Main(string[] args)
    {
    
    
      int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
    
      // LINQ query!
      var subset = from i in numbers where i < 10 select i;

      Console.Write("Values in subset: ");
      foreach (var i in subset)
      {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();

      // Hmm...what type is subset?
      Console.WriteLine("subset is a: {0}", subset.GetType().Name);
      Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        
        return 0;
    }
} 