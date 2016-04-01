using System;

class ArrayInitialization {
    
    public static void Main(string[] args)
    {
        Console.WriteLine("=> Array Initialization.");

  // Array initialization syntax using the new keyword.
  string[] stringArray = new string[]
    { "one", "two", "three" };
  Console.WriteLine("stringArray has {0} elements", stringArray.Length);

  // Array initialization syntax without using the new keyword.
      bool[] boolArray = { false, false, true };
      Console.WriteLine("boolArray has {0} elements",, boolArray.Length);
    }
}

