using System;
using System.Collections.Generic;
using System.Globalization;

class DataProccessor
{
    int[] numbers = new int[10];
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("=== 원본 배열 출력 ===");
        
    }


    void Foreach(Action<int> action)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            action(numbers[i]);
        }
    }
}