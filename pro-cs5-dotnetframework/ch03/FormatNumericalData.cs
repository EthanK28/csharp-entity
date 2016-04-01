using System;

//using System.Windows.Forms;

class FormatNumericalData
{
    static int Main(string[] args)
    {
        Console.WriteLine("The value 99999 in various foramts: ");
        Console.WriteLine("C Format: {0:c}", 99999);
        Console.WriteLine("d9Format: {0:d9}", 99999);        
        Console.WriteLine("f3 Format: {0:f3}", 99999);
        Console.WriteLine("n Format: {0:n}", 99999);
        
        Console.WriteLine("E Format: {0:E}", 99999);
        Console.WriteLine("e Format: {0:e}", 99999);
        Console.WriteLine("X Format: {0:X}", 99999);
        Console.WriteLine("x Format: {0:x}", 99999);        
        
        return 0;
    }
} 