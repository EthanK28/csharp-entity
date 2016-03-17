using System;

delegate void Del(string str);



public class Delegate  {

    static void Notify(string name)
    {
        Console.WriteLine("Notificatino recevied for: {0}", name);
    }
    
    public static void Main(string []args)
    {
        Del del1 = new Del(Notify);
        del1("del1");
        
        Del del2 = Notify;
        del2("del2");
        
        Del del3 = delegate(string name)
            { Console.WriteLine("Notification received for: {0}", name); };
        del3("del3");
    }
}
