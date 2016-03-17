using System;


delegate bool D();
delegate bool D2(int i);


class Test
{
    D del;
    D2 del2;
    public void TestMethod(int input)
    {
        int j = 0;
        
        del = () => { 
            j = 10; 
            return j > input; };
        
        del2 = (x) => { return x == j; };
        
        // Demonstrate value of j;
        // Output: j = 0
        // The delegate has not been invoked yet
        Console.WriteLine("j = {0}", j);
        bool boolResult = del();
        
        // Output: j = 10b = true
        Console.WriteLine("j = {0}. b = {1}", j, boolResult);               
        
    }
    
   static void Main()
   {
        Test test = new Test();
        test.TestMethod(5);
        
        
        // Prove that del2 still ha a copy of 
        // local variable j from TestMethod.
        bool result = test.del2(11);
        
        // Output: true
        Console.WriteLine(result);        
        Console.ReadKey();
   }
}