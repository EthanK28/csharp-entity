using System;
 
 // Delegate를 쓰는 가장 큰 이유는 콜백 메섣
 
namespace CS_Lecture
{
    
    // 델리게이트 일반화 가능
    delegate T MyDelegate<T> (T a, T b);

    class MainApp
    {        
        public static void Calculator( int a, int b, MyDelegate dele)
        {
            Console.WriteLine(dele(a, b));
        }
        
        public static int plus(int a, int b) { return a + b; }
        public static float plus(float a, float b) { return a + b; }
        public static double plus(double a, double b) { return a + b; }
        
        static void Main(string[] args)
        {
            MyDelegate<int> Plus_int = new MyDelegate<int>(plus);
            MyDelegate<float> Plus_float = new MyDelegate<float>(plus);
            MyDelegate<double> Plus_double = new MyDelegate<double>(plus);
            
            Calculator(11, 22, Plus_int); // 
            Calculator(3.3f, 4.4f, Plus_float); // float 덧셈
            Calculator(5.5, 6.6, Plus_double); // double 덧셈                       
            
            // MyDelegate calculate;

            // calculate =  new MyDelegate(Plus);
            // int sum = calculate(11, 22);
            // Console.WriteLine("11 + 22 = {0}", sum);
            
            // calculate = new MyDelegate(Minus);
            // Console.WriteLine("22 - 11 = {0}", calculate(22, 11));
            
        }
    }
}