namespace Day2
{

    static class ArrayUtility
    {
        public static void GetMinAndMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];

            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }

            }
            Console.WriteLine($"the max is {max}");
            Console.WriteLine($"the min is {min}");

        }
        public static int[] SortArray(int[] numbers)
        {
            //bubble sort
            foreach (var i in numbers)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        //swap
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
        public static int SearchNumber(int[] numbers, int num)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int[,] ReadAndWriteArray()
        {
            int[,] numbers = new int[3, 4];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    int n;
                    do
                    {
                        Console.WriteLine($"enter number [{i}][{j}]");
                    }
                    while (!int.TryParse(Console.ReadLine(), out n));
                    numbers[i, j] = n;


                }
            }
            return numbers;
        }

    }
}