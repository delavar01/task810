using System;

public class avgNumber
{
    public static void avg()
    {
        double sumNum = 0;
        int userNum = 0;
        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"Please Enter Number{i}: ");
            userNum = Convert.ToInt32(Console.ReadLine());
            sumNum += userNum;
        }
        Console.WriteLine($"Your Abg Numbers:{sumNum / 20}");
    }
}