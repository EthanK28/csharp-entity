public class MyBase
{
    public virtual string Meth1()
    {
        return "MyBase-Meth1";
    }
    
    public virtual string Meth2()
    {
        return "MyBase-Meth2";
    }
    
    public virtual string Meth3()
    {
        return "MyBase-Meth3";
    }
    
    
}

class MyDerived: MyBase
{
    public override string Meth1() 
    {
        return "MyDerived 1";
    }s
    
    public new string Meth2() 
   {
      return "MyDerived-Meth2";
   }
   
   public string Meth3()
   {
       return "MyDerived-Meth3";
   }
   
   
    s
    public static void Main()
    {
        MyDerived mD = new MyDerived();
        MyBase mB = (MyBase) mD;
        
        System.Console.WriteLine(mB.Meth1());
        System.Console.WriteLine(mB.Meth2());
        System.Console.WriteLine(mB.Meth3());
        
        System.Console.WriteLine(mD.Meth1());
        System.Console.WriteLine(mD.Meth2());
        System.Console.WriteLine(mD.Meth3());
      
    }
}