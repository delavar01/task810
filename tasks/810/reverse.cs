using System;

public class reverseNumber
{
    public static void reverseNumberFunc()
    {
        int userNum = 0;
        string reversedNumberString = "";
        Console.Write("Please Enter Number: ");
        userNum = Convert.ToInt32(Console.ReadLine());
        while (userNum != 0)
        {
            reversedNumberString += userNum % 10;
            userNum /= 10;
        }
        Console.WriteLine($"Reversed Your Number is: {reversedNumberString}");
    }
}