using System;

class Program
{
    static void Main()
    {
        //DisplayHelloFromDLL();
        //CreateSerialNumber();

        var sumResult = CustomCalculator.Math.GetSum(1, 5);
        Console.WriteLine("Sum result is : " + sumResult);
        
        var minusResult = CustomCalculator.Math.Minus(81, 5);
        Console.WriteLine("Minus result is : " + minusResult);

        var minusResultError = CustomCalculator.Math.Minus(-10,5);
        Console.WriteLine("Minus result is : " + minusResultError);

        Console.ReadLine();
    }
}