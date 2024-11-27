using System;
using C_810;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int userChoice;
        Console.WriteLine("Which program do you want to run?");
        Console.WriteLine("[1] Calculation avg and show best students");
        Console.WriteLine("[2] duplicate valuse in two array");
        Console.WriteLine("[3] print duplicate");
        Console.WriteLine("[4] task 4");
        Console.WriteLine("[4] task 5");
        Console.WriteLine("[4] task 6");
        // Console.WriteLine("[7] check equal two array");
        // Console.WriteLine("[8] move zero to last index");
        // Console.WriteLine("[9] shift array");
        // Console.WriteLine("[10] sort array");
        // Console.WriteLine("[11] print sum numbers :|");
        Console.Write("\n Enter Your Choice: ");
        userChoice = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Blue;
        switch (userChoice)
        {
            case 1:
                Task824.T1();
                break;
            case 2:
                Task824.T2();
                break;
            case 3:
                Task824.T3();
                break;
            case 4:
                Task824.T4();
                break;
            case 5:
                Task824.T5();
                break;
            case 6:
                Task824.T6();
                break;
            // case 7:
            //     Task824.CheckEqualTwoArray();
            //     break;
            // case 8:
            //     Task824.MoveZero();
            //     break;
            // case 9:
            //     Task824.shiftArray();
            //     break;
            // case 10:
            //     Task824.sortArray();
            //     break;
            // case 11:
            //     // Task824.lastTaskFunc();
            //     break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Choice in not exist :(");
                break;
        }
    }
}