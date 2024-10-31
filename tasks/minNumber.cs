using System;

public class MinNumber
{
    public static void min()
    {
        Console.Write("Please Enter Number1: ");
        int minNum = Convert.ToInt32(Console.ReadLine());
        int userNum = 0;
        for (int i = 2; i <= 20; i++)
        {
            Console.Write($"Please Enter Number{i}: ");
            userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum < minNum)
            {
                minNum = userNum;
            }
        }
        Console.WriteLine($"Your Min Number:{minNum}");
    }
}