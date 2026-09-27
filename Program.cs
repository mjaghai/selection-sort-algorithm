

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("چند عدد می خواهید وارد کنید؟");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("اعداد را وارد کنید:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // مرتب سازی با استفاده از الگوریتم انتخاب
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            // تعویض دو عدد
            int temp = numbers[minIndex];
            numbers[minIndex] = numbers[i];
            numbers[i] = temp;
        }

        Console.WriteLine("اعداد مرتب شده:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.ReadKey();
    }
}

