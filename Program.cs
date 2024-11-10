using System;
using C_810;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int userChoice;
        Console.WriteLine("Which program do you want to run?");
        Console.WriteLine("[1] delete a number from array");
        Console.WriteLine("[2] copy array");
        Console.WriteLine("[3] replace a number in array");
        Console.WriteLine("[4] print duplicate numbers in array");
        Console.WriteLine("[5] print duplicate numbers in two array");
        Console.WriteLine("[6] delete duplicate numbers in a array");
        Console.WriteLine("[7] check equal two array");
        Console.WriteLine("[8] move zero to last index");
        Console.WriteLine("[9] shift array");
        Console.WriteLine("[10] sort array");
        // Console.WriteLine("[11] print sum numbers :|");
        Console.Write("\n Enter Your Choice: ");
        userChoice = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Blue;
        switch (userChoice)
        {
            case 1:
                Task817.DeleteNumberFromArray();
                break;
            case 2:
                Task817.CopyArray();
                break;
            case 3:
                Task817.ReplaceNumberInArray();
                break;
            case 4:
                Task817.PrintDuplicateNumbers();
                break;
            case 5:
                Task817.PrintDuplicateNumbersInTwoArray();
                break;
            case 6:
                Task817.DeleteDuplicateNumberOfArray();
                break;
            case 7:
                Task817.CheckEqualTwoArray();
                break;
            case 8:
                Task817.MoveZero();
                break;
            case 9:
                Task817.shiftArray();
                break;
            case 10:
                Task817.sortArray();
                break;
            case 11:
                // Task817.lastTaskFunc();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Choice in not exist :(");
                break;
        }
    }
}