using System;

public class printFirstNumbers
{
    public static void printFirstNumbersFunc()
    {
        for (int num = 0; num <= 1000; num++)
        {
            bool isFirst = true;
            if (num <= 1)
            {
                isFirst = false;
            }
            else if (num == 2 || num == 3)
                isFirst = true;
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isFirst = false;
                        break;
                    }
                }
            }
            if (isFirst)
            {
                Console.WriteLine(num);
            }
        }
    }
}