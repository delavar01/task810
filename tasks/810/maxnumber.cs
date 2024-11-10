using System;

public class MaxNumber
{
    public static void max()
    {
        Console.Write("Please Enter Number1: ");
        int maxNum = Convert.ToInt32(Console.ReadLine());
        int userNum = 0;
        for (int i = 2; i <= 20; i++)
        {
            Console.Write($"Please Enter Number{i}: ");
            userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum > maxNum)
            {
                maxNum = userNum;
            }
        }
        Console.WriteLine($"Your Max Number:{maxNum}");
    }
}