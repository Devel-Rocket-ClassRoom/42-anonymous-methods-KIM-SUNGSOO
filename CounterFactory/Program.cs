using System;

// README.md를 읽고 아래에 코드를 작성하세요.
class CounterFactory
{

    static void Main()
    {
        Console.WriteLine("=== 단순 카운터 ===");
        Func<int> counter1 = CreateSimpleCounter();
        Func<int> counter2 = CreateStepCounter(3);
        Func<int> counter3 = CreateBoundedCounter(1, 3);
        Func<int> counter4;
        Action reset;
        for (int i = 0; i <5; i++)
        {
            
            CreateSimpleCounter();
            Console.Write($"{counter1()} ");
        }
        Console.WriteLine();
        Console.WriteLine("=== 스텝 카운터 (step= 3) ===");
        for (int i = 0; i < 4;  i++)
        {
            Console.Write($"{counter2()} ");
        }
        Console.WriteLine();
        Console.WriteLine("=== 범위 카운터 (1~3) ===");
        for (int i = 0; i< 7; i++)
        {
            Console.Write($"{counter3()} ");
        }
        Console.WriteLine();
        Console.WriteLine("=== 리셋 가능 카운터 ===");
        CreateResettableCounter(out counter4, out reset);
        Console.Write("호출: ");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{counter4()} ");
        }

        Console.WriteLine();

        reset();

        Console.Write("리셋 후: ");
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"{counter4()} ");
        }

    }
    static Func<int> CreateSimpleCounter()
    {
        int counter = 0;
        return delegate
        {
            counter++;
            return counter; 
        };
    }
    static Func<int> CreateStepCounter(int step)
    {
        int counter = 0;
        return delegate
        {
            for (int i = 0; i < step; i++)
            {
                counter++;
            }
            return counter;
        };
    }
    static Func<int> CreateBoundedCounter(int min, int max)
    {
        int counter = min;

        return delegate
        {
            int result = counter;

            counter++;

            if (counter > max)
            {
                counter = min;
            }

            return result;
        };
    }
    static void CreateResettableCounter(out Func<int> increment, out Action reset)
    {
        int counter = 0;

        increment = () =>
        {
            counter++;
            return counter;
        };

        reset = () =>
        {
            counter = 0;
        };
    }



}