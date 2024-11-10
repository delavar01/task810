using System;

public class Fact
{
    public static void factFunc()
    {
        int userNum = 0;
        int fact = 1;
        Console.Write("Please Enter Your Number: ");
        userNum = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= userNum; i++)
        {
            fact *= i;
        }
        Console.WriteLine($"factorial your number is: {fact}");
    }
}