using System;

public class rightIsFive
{
    public static void rightNumberIsFive()
    {
        int userNum = 0;
        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"Please Enter Number{i}: ");
            userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum % 10 == 5)
            {
                Console.WriteLine($"Right Number {userNum} is five! :)");
            }
        }
    }
}