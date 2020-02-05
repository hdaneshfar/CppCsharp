using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomCalculator
{
    #region Cpp Project
    //https://www.codeproject.com/Articles/9826/How-to-create-a-DLL-library-in-C-and-then-use-it-w
    //1-Select Visual C++ Project, and from the “Templates”, select “Win32 Project”.
    //2-Give the name to your project.This will be the name of your final DLL (in my case: TestLib).
    //3-Press OK.
    //4-Select DLL from “Application Type” (“Application Settings” tab).
    //5-Check “Empty Project” (we need to create our project from scratch, right?), and press Finish.
    #endregion Cpp Project

    public static class Math
    {
        [DllImport("CppTest.dll")]
        public static extern void DisplayHelloFromDLL();

        [DllImport("CppTest.dll")]
        public static extern void CreateSerialNumber();

        [DllImport("CppTest.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Sum")]
        public static extern int GetSum(int firstNumber, int secondNumber);

        [DllImport("CppTest.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Minus(int firstNumber, int secondNumber);
    }
}
