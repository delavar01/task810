using System;

public class Qarine
{
    public static void QarineFunc()
    {
        int n1, n2, n3, n4;

        for (int i = 1000; i <= 9999; i++)
        {
            int checkNum = i;

            n4 = i % 10;
            i /= 10;
            n3 = i % 10;
            i /= 10;
            n2 = i % 10;
            i /= 10;
            n1 = i % 10;

            i = checkNum;

            if (n1 == n4 && n2 == n3)
            {
                Console.WriteLine(checkNum);
            }
        }
    }
}
