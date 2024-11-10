using System;

public class lastTask
{
    public static void lastTaskFunc()
    {
        int sum = 1;
        Console.Write("Please Enter Number: ");
        int userNum = Convert.ToInt32(Console.ReadLine());
        bool qarine = false;
        for (int i = 2; i <= userNum; i++)
        {
            if (qarine)
            {
                sum += -i;
                qarine = false;
            }
            else
            {
                qarine = true;
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
}
