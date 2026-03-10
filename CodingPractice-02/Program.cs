using System;

class codPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2();
        //Prac_3();
        //Prac_4();
        Prac_5();
    }

    static void Prac_1()
    {
        Calculator calc = delegate (int x)
        {
            return x * x; 
        };
        Console.WriteLine(calc(5));
    }
    static void Prac_2()
    {
        int factor = 3;
        Func<int, int> multiplier = delegate (int n)
        { 
            return n * factor; 
        };
        Console.WriteLine(multiplier(10));
    }
    static void Prac_3()
    {
        int factor = 2;
        Func<int, int> multiplier = delegate (int n)
        {
            return n * factor;
        };
        Console.WriteLine($"factor = 2 일떄: {multiplier(5)}");
        factor = 10;
        Console.WriteLine($"factor = 10 일떄: {multiplier(5)}");

    }
    static void Prac_4()
    {
        int counter = 0;
        Action increment = delegate ()
        {
            counter++;
            Console.WriteLine($"현재 카운터: {counter}");
        };
        increment();
        increment();
        increment();
        Console.WriteLine($"최종 카운터: {counter}");
    }
    static void Prac_5()
    {
        Func<int> counter1 = CreateCounter();
        Func<int> counter2 = CreateCounter();
        Console.WriteLine($"counter1 : {counter1()}");
        Console.WriteLine($"counter1 : {counter1()}");
        Console.WriteLine($"counter1 : {counter1()}");
        Console.WriteLine($"counter2 : {counter2()}");
        Console.WriteLine($"counter2 : {counter2()}");
        Func<int> CreateCounter()
        {
            int count = 0;
            return delegate
            {
                count++;
                return count;
            };
        }
    }

}

delegate int Calculator(int a);

