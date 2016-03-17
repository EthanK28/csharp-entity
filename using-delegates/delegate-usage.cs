using System;




// Delegate를 사용하는 3가지 방법이 있다
/*

1. 직접 대입

2. 대리자 인스턴스 생성


*/
public class MethodClass
{
    public void Method1(string message) {
        System.Console.WriteLine(message);
     }
    public void Method2(string message) { 
        System.Console.WriteLine(message);
    }
    
    public void Method3(string msg1, string msg2)
    {
        System.Console.WriteLine(message);
    }
}



public class Delegate  {
    
    public delegate void Del(string message);

    public static void DelegateMethod(string message)
    {
        System.Console.WriteLine(message);
    }
    
    public static void MethodWithCallback(int param1, int param2, Del callback)
    {
        callback("The number is: " + (param1 + param2).ToString());
    }
    
    public static void Main(string []args)
    {
        Del handler = DelegateMethod;
        // handler("Hello World");
        // MethodWithCallback(1, 2, handler);
        MethodClass obj = new MethodClass();
        Del d1 = obj.Method1;
        Del d2 = obj.Method2;
        Del d3 = DelegateMethod;
        
        
        Del allMethodsDelegate = d1 + d2;
        allMethodsDelegate += d3;
        
        allMethodsDelegate("hey");
        
    }
}
