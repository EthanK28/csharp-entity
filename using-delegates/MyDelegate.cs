using System;
 
 // Delegate를 쓰는 가장 큰 이유는 콜백 메섣
 
namespace CS_Lecture
{
    
    
    delegate int MyDelegate(int a, int b);
    // 델리게이트 일반화 가능
    
    
    class MainApp
    {
    
        
        public static void Calculator( int a, int b, MyDelegate dele)
        {
            Console.WriteLine(dele(a, b));
        }
        
        public static int plus(int a, int b) { return a + b; }
        public static int minus (int a, int b) { return a - b; }
        public static int multiply(int a, int b) { return a * b; }
        
        static void Main(string[] args)
        {
            MyDelegate Plus = new MyDelegate(plus);
            MyDelegate Minus = new MyDelegate(minus);
            MyDelegate Multiply = new MyDelegate(multiply);
            
            Calculator(11, 22, Plus);
            Calculator(33, 22, Minus);
            Calculator(11, 22, Multiply);
                       
            
            // MyDelegate calculate;

            // calculate =  new MyDelegate(Plus);
            // int sum = calculate(11, 22);
            // Console.WriteLine("11 + 22 = {0}", sum);
            
            // calculate = new MyDelegate(Minus);
            // Console.WriteLine("22 - 11 = {0}", calculate(22, 11));
            
        }
    }
}