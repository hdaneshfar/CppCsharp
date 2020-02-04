using System;
using System.Runtime.InteropServices;
class Program
{
    #region Cpp Project
    //https://www.codeproject.com/Articles/9826/How-to-create-a-DLL-library-in-C-and-then-use-it-w
    //1-Select Visual C++ Project, and from the “Templates”, select “Win32 Project”.
    //2-Give the name to your project.This will be the name of your final DLL (in my case: TestLib).
    //3-Press OK.
    //4-Select DLL from “Application Type” (“Application Settings” tab).
    //5-Check “Empty Project” (we need to create our project from scratch, right?), and press Finish.
    #endregion Cpp Project
        
    [DllImport("CppTest.dll")]
    public static extern void DisplayHelloFromDLL();

    [DllImport("CppTest.dll")]
    public static extern void CreateSerialNumber();

    [DllImport("CppTest.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Sum(int firstNumber, int secondNumber);

    [DllImport("CppTest.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Minus(int firstNumber, int secondNumber);

    static void Main()
    {
        //DisplayHelloFromDLL();
        //CreateSerialNumber();

        var sumResult = Sum(1, 5);
        Console.WriteLine("Sum result is : " + sumResult);
        
        var minusResult = Minus(81, 5);
        Console.WriteLine("Minus result is : " + minusResult);

        Console.ReadLine();
    }
}