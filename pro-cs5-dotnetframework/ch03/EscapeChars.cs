using System;

//using System.Windows.Forms;

class FormatNumericalData
{
    static int Main(string[] args)
    {
        Console.WriteLine("=> Escape characters:\a");
        string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
        Console.WriteLine(strWithTabs);

        Console.WriteLine("Everyone loves \"Hello World\"\a ");
        Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");

          // Adds a total of 4 blank lines (then beep again!).
        Console.WriteLine("All finished.\n\n\n\a ");
        Console.WriteLine();    
        
        return 0;
    }
} 