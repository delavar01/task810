using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int userChoice;
        Console.WriteLine("Which program do you want to run?");
        Console.WriteLine("[1] Find Min number in 20 numbers");
        Console.WriteLine("[2] Find max number in 20 numbers");
        Console.WriteLine("[3] Calculate the average number in 20 numbers");
        Console.WriteLine("[4] Check Right Number in 20 numbers");
        Console.WriteLine("[5] Calculate the factorial");
        Console.WriteLine("[6] check number length");
        Console.WriteLine("[7] Reverse Your Number");
        Console.WriteLine("[8] check is first number");
        Console.WriteLine("[9] print first numbers between 1 - 1000");
        Console.WriteLine("[10] print qarine numbers between 1000 - 9999");
        Console.WriteLine("[11] print sum numbers :|");
        Console.Write("\n Enter Your Choice: ");
        userChoice = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Blue;
        switch (userChoice)
        {
            case 1:
                MinNumber.min();
                break;
            case 2:
                MaxNumber.max();
                break;
            case 3:
                avgNumber.avg();
                break;
            case 4:
                rightIsFive.rightNumberIsFive();
                break;
            case 5:
                Fact.factFunc();
                break;
            case 6:
                checkLength.lengthFunc();
                break;
            case 7:
                reverseNumber.reverseNumberFunc();
                break;
            case 8:
                firstNumber.firstNumberFunc();
                break;
            case 9:
                printFirstNumbers.printFirstNumbersFunc();
                break;
            case 10:
                Qarine.QarineFunc();
                break;
            case 11:
                lastTask.lastTaskFunc();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Choice in not exist :(");
                break;
        }
    }
}