namespace C_810;

public class Task824
{
    public static void T1()
    {
        Console.Write("please enter users count:");
        int count = Convert.ToInt32(Console.ReadLine());
        string[] names = new string[count];
        int[] studenstId = new int[count];
        double[] avgs = new double[count];
        double sum = 0;
        double allAvg = 0;
        for (int i = 0; i < count; i++)
        {
            Console.Write("please enter student name:");
            string name = Convert.ToString(Console.ReadLine());
            names[i] = name;

            Console.Write("please enter student id:");
            int id = Convert.ToInt32(Console.ReadLine());
            studenstId[i] = id;

            Console.Write("please enter student avg:");
            double avg = Convert.ToInt32(Console.ReadLine());
            avgs[i] = avg;
            sum += avg;
        }
        allAvg = sum / count;
        Console.WriteLine(allAvg);
        for (int i = 0; i < count; i++)
        {
            if (avgs[i] > allAvg)
            {
                Console.WriteLine($"sutdent: {names[i]} withId: {studenstId[i]} withAvg: {avgs[i]}");

            }
        }

    }

    public static void T2()
    {
        Console.Write("please enter arrOne length:");
        int countArrOne = Convert.ToInt32(Console.ReadLine());
        Console.Write("please enter arrTwo length:");
        int countArrtow = Convert.ToInt32(Console.ReadLine());
        int[] arrOne = new int[countArrOne];
        int[] arrTwo = new int[countArrtow];
        for (int i = 0; i < countArrOne; i++)
        {
            Console.Write("please enter number array one:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                bool exist = false;
                for (int j = 0; j < countArrOne; j++)
                {
                    if (userNum == arrOne[j])
                    {
                        Console.WriteLine(userNum);
                        Console.WriteLine(arrOne[j]);
                        exist = true;
                    }
                }
                if (exist)
                {
                    Console.Write("number is exist please enter number again:");
                    userNum = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    arrOne[i] = userNum;
                    break;
                }
            }
        }
        for (int i = 0; i < countArrtow; i++)
        {
            Console.Write($"please enter number array two:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                bool exist = false;
                for (int j = 0; j < countArrtow; j++)
                {
                    if (userNum == arrTwo[j])
                    {
                        exist = true;
                    }
                }
                if (exist)
                {
                    Console.Write("number is exist please enter number again:");
                    userNum = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    arrTwo[i] = userNum;
                    break;
                }
            }
        }
        for (int i = 0; i < countArrOne; i++)
        {
            for (int j = 0; j < countArrtow; j++)
            {
                if (arrOne[i] == arrTwo[j])
                {
                    Console.WriteLine(arrOne[i]);
                    break;
                }
            }
        }
    }
    public static void T3()
    {
        int[] arrOne = { 1, 2, 3, 4, 2, 3, 4, 2, 4, 4, };
        int mostRepeated = 0;
        int findDuplicateCount = 0;
        for (int i = 0; i < arrOne.Length; i++)
        {
            int findDuplicate = 1;
            for (int j = 0; j < arrOne.Length; j++)
            {
                if (arrOne[i] == arrOne[j])
                {
                    findDuplicate++;
                }
            }
            if (findDuplicate > findDuplicateCount)
            {
                mostRepeated = arrOne[i];
            }
        }
        Console.WriteLine(mostRepeated);
    }
    public static void T4()
    {
        int[] arrOne = { 1, 2, 3, 4, 2, 3, 4, 2, 4, 4, };
        int mostRepeated = 0;
        int findDuplicateCount = 0;
        for (int i = 0; i < arrOne.Length; i++)
        {
            int findDuplicate = 1;
            for (int j = 0; j < arrOne.Length; j++)
            {
                if (arrOne[i] == arrOne[j])
                {
                    findDuplicate++;
                }
            }
            if (findDuplicate > findDuplicateCount)
            {
                mostRepeated = arrOne[i];
            }
        }
        Console.WriteLine(mostRepeated);
    }

    public static void T5()
    {
        Console.WriteLine("enter count of student:");
        int studentnum = Convert.ToInt32(Console.ReadLine());
        int[] numberofstudent = new int[studentnum];
        int[] eduction = new int[studentnum];
        for (int i = 0; i < studentnum; i++)
        {
            Console.WriteLine($"enter student code:{i + 1}");
            int studentcode = Convert.ToInt32(Console.ReadLine());
            numberofstudent[i] = studentcode;
            Console.WriteLine("kardini:1  bachlor:2");
            int eductionuser = Convert.ToInt32(Console.ReadLine());
            eduction[i] = eductionuser;
        }
        for (int i = 0; i < studentnum; i++)
        {
            if (eduction[i] == 1)
                Console.WriteLine($"kardani\n{numberofstudent[i]}");
        }
        for (int i = 0; i < studentnum; i++)
        {


            if (eduction[i] == 2)
                Console.WriteLine($" bachlor\n{numberofstudent[i]}");
        }

    }

    public static void T6()
    {
        double[] arrOne = { 10.5, 16.5, 17.5, 14.5, };
        double sum = 0;
        for (int i = 0; i < arrOne.Length; i++)
        {
            sum += arrOne[i];
        }
        double avg = sum / arrOne.Length;
        for (int i = 0; i < arrOne.Length; i++)
        {
            arrOne[i] = (arrOne[i] - avg) * (arrOne[i] - avg);
        }
        sum = 0;
        for (int i = 0; i < arrOne.Length; i++)
        {
            sum += arrOne[i];
        }
        double variance = sum / arrOne.Length;
        Console.WriteLine(variance);
    }

}