using System;

public class firstNumber
{
    public static void firstNumberFunc()
    {
        bool isFirst = true;
        Console.Write("Please Enter Number: ");
        int userNum = Convert.ToInt32(Console.ReadLine());
        if (userNum <= 1)
        {
            isFirst = false;
        }
        else if (userNum == 2 || userNum == 3)
            isFirst = true;
        else
        {
            for (int i = 2; i <= Math.Sqrt(userNum); i++)
            {
                if (userNum % i == 0)
                {
                    isFirst = false;
                    break;
                }
            }
        }

        Console.WriteLine($"The result of checking the number is first: {isFirst}");
    }
}