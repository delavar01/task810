namespace C_810;

public class Task817
{
    public static void DeleteNumberFromArray()
    {
        int arrayLength = 0;
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.Write("Enter Number from 1 To 10 For Remove:");
        int userNum = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != userNum)
            {
                arrayLength++;
            }
        }

        int[] numbersWithDelete = new int[arrayLength];
        int numbersWithDeleteIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != userNum)
            {
                numbersWithDelete[numbersWithDeleteIndex] = numbers[i];
                numbersWithDeleteIndex++;
            }
        }

        foreach (int number in numbers)
        {
            Console.Write($"{number}, ");
        }
        Console.WriteLine();
        foreach (int number in numbersWithDelete)
        {
            Console.Write($"{number}, ");
        }
    }
    public static void CopyArray()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            array2[i] = array1[i];
        }
        foreach (int number in array1)
        {
            Console.Write($"{number}, ");
        }
        Console.WriteLine();
        foreach (int number in array2)
        {
            Console.Write($"{number}, ");
        }
    }
    public static void ReplaceNumberInArray()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.Write("Enter Number:");
        int userNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Where in The array between 0 To 9:");
        int userIndex = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= numbers.Length; i++)
        {
            if (i == userIndex)
            {
                numbers[i] = userNum;
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"the array index {i}: {numbers[i]}");
        }
    }
    public static void PrintDuplicateNumbers()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 10, 11, 12, 2, 5, 6, 2 };
        int[] duplicateValues = new int[numbers.Length];
        int duplicateArrayIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    bool exist = false;
                    foreach (int numberDuplicate in duplicateValues)
                    {
                        if (numberDuplicate == numbers[i])
                        {
                            exist = true;
                        }
                    }
                    if (!exist)
                    {
                        duplicateValues[duplicateArrayIndex] = numbers[i];
                        duplicateArrayIndex++;
                    }
                }
            }
        }
        foreach (int number in duplicateValues)
        {
            if (number != 0)
            {
                Console.WriteLine(number);
            }
        }

    }
    public static void PrintDuplicateNumbersInTwoArray()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 10, 11, 12, 2, 5, 6, 2 };
        int[] numbers2 = { 7, 8, 9, 10, 2, 11, 6 };
        int[] duplicateValues = new int[numbers.Length];
        int duplicateArrayIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers2.Length; j++)
            {
                if (numbers[i] == numbers2[j])
                {
                    bool exist = false;
                    foreach (int numberDuplicate in duplicateValues)
                    {
                        if (numberDuplicate == numbers[i])
                        {
                            exist = true;
                        }
                    }
                    if (!exist)
                    {
                        duplicateValues[duplicateArrayIndex] = numbers[i];
                        duplicateArrayIndex++;
                    }
                }
            }
        }
        foreach (int number in duplicateValues)
        {
            if (number != 0)
            {
                Console.WriteLine(number);
            }
        }

    }
    public static void DeleteDuplicateNumberOfArray()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 10, 11, 12, 2, 5, 6, 2 };
        int[] duplicateValues = new int[numbers.Length];
        int duplicateArrayIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    bool exist = false;
                    foreach (int numberDuplicate in duplicateValues)
                    {
                        if (numberDuplicate == numbers[i])
                        {
                            exist = true;
                        }
                    }
                    if (!exist)
                    {
                        duplicateValues[duplicateArrayIndex] = numbers[i];
                        duplicateArrayIndex++;
                    }
                }
            }
        }
        int[] finalArray = new int[numbers.Length];
        int finalArrayIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < duplicateValues.Length; j++)
            {
                if (numbers[i] == duplicateValues[j])
                {
                    isDuplicate = true;
                }
            }
            if (!isDuplicate)
            {
                finalArray[finalArrayIndex] = numbers[i];
                finalArrayIndex++;
            }
        }
        foreach (int number in finalArray)
        {
            if (number != 0)
            {
                Console.WriteLine(number);
            }
        }
    }
    public static void CheckEqualTwoArray()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 10, 11, 12, 2, 5, 6, 2 };
        int[] numbers2 = { 1, 2, 3, 4, 5, 6, 10, 111, 12, 2, 5, 6, 2 };
        bool isEqual = true;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != numbers2[i])
            {
                isEqual = false;
            }
        }
        if (isEqual)
        {
            Console.WriteLine("The two array are equal");
        }
        else
        {
            Console.WriteLine("The two array are not equal");
        }
    }
    public static void MoveZero()
    {
        int[] array = { 1, 2, 0, 0, 0, 0, 5, 6, 0, 4, 2, 0, 0, 77 };
        int zeroIndexCounter = array.Length - 1;
        int arrayLength = array.Length;
        int temp;
        for (int i = 0; i < arrayLength; i++)
        {
            if (array[i] == 0)
            {
                temp = array[i];
                array[i] = array[zeroIndexCounter];
                array[zeroIndexCounter] = temp;
                i--;
                zeroIndexCounter--;
                arrayLength--;
            }
        }
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }
    }
    public static void shiftArray()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int firstIndexValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {

            if (i < array.Length - 1)
            {
                array[i] = array[i + 1];
            }
            else
            {
                array[i] = firstIndexValue;
            }
        }
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
    public static void sortArray()
    {
        int[] numbers = { -3, -5, 3, -1, 9, 33, -56, -3, 6, 7, -4, 2 };

        int firstNumberIndex = 0;
        int lastNumberIndex = numbers.Length - 1;

        while (firstNumberIndex < lastNumberIndex)
        {
            if (numbers[firstNumberIndex] < 0)
            {
                firstNumberIndex++;
            }
            else if (numbers[lastNumberIndex] > 0)
            {
                lastNumberIndex--;
            }
            else
            {
                int temp = numbers[firstNumberIndex];
                numbers[firstNumberIndex] = numbers[lastNumberIndex];
                numbers[lastNumberIndex] = temp;

                firstNumberIndex++;
                lastNumberIndex--;
            }
        }

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }

}