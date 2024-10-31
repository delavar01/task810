using System;

public class checkLength
{
    public static void lengthFunc()
    {
        int userNum = 0;
        int numberLength = 0;
        Console.Write("Please Enter Your Number: ");
        userNum = Convert.ToInt32(Console.ReadLine());
        while (userNum != 0)
        {
            userNum /= 10;
            numberLength++;
        }
        Console.WriteLine($"your number length is: {numberLength}");
    }
}