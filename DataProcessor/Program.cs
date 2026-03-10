using System;
using System.Collections.Generic;
using System.Globalization;

class DataProcessor
{
    private int[] data;

    
    public DataProcessor(int[] data)
    {
        this.data = data;
    }

    
    public void ForEach(Action<int> action)
    {
        for (int i = 0; i < data.Length; i++)
        {
            action(data[i]);
        }
    }

    
    public int[] Transform(Func<int, int> transformer)
    {
        int[] result = new int[data.Length];

        for (int i = 0; i < data.Length; i++)
        {
            result[i] = transformer(data[i]);
        }

        return result;
    }

    
    public List<int> Filter(Func<int, bool> predicate)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < data.Length; i++)
        {
            if (predicate(data[i]))
            {
                result.Add(data[i]);
            }
        }

        return result;
    }

    
    public int Reduce(Func<int, int, int> reducer, int initialValue)
    {
        int result = initialValue;

        for (int i = 0; i < data.Length; i++)
        {
            result = reducer(result, data[i]);
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        DataProcessor processor = new DataProcessor(numbers);

        Console.WriteLine("=== 원본 배열 출력 ===");

        processor.ForEach(delegate (int x)
        {
            Console.Write(x + " ");
        });

        Console.WriteLine("\n");

        Console.WriteLine("=== 2배로 변환 ===");

        int[] doubled = processor.Transform(delegate (int x)
        {
            return x * 2;
        });

        for (int i = 0; i < doubled.Length; i++)
        {
            Console.Write(doubled[i] + " ");
        }

        Console.WriteLine("\n");

        Console.WriteLine("=== 짝수만 필터링 ===");

        List<int> evens = processor.Filter(delegate (int x)
        {
            return x % 2 == 0;
        });

        for (int i = 0; i < evens.Count; i++)
        {
            Console.Write(evens[i] + " ");
        }

        Console.WriteLine("\n");

        Console.WriteLine("=== 합계 계산 ===");

        int sum = processor.Reduce(delegate (int acc, int x)
        {
            return acc + x;
        }, 0);

        Console.WriteLine($"합계: {sum}");
    }
}