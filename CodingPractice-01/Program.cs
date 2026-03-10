using System;

// README.md를 읽고 아래에 코드를 작성하세요.
class CodPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2();
        //Prac_3();
        //Prac_4();
        //Prac_5();
        Prac_6();
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
        Transformer sqaure = delegate (int x)
        { 
            return x * x; 
        };

        Transformer cube = delegate (int x)
        {
            return x * x * x;
        };

        Console.WriteLine($"3의 제곱: {sqaure(3)}");
        Console.WriteLine($"3의 세제곱: {cube(3)}");
    }
    static void Prac_3()
    {
        Printer greet = delegate (string str)
        {
            Console.WriteLine($"[메시지] {str}"); 
        };

        greet("안녕하세요!");
        greet("익명 메서드를 사용 중입니다.");
    }
    static void Prac_4()
    {
        Func<int,int> doubler = delegate (int x )
        {
            return x * 2; 
        };

        Action<string> logger = delegate (string msg)
        {
            Console.WriteLine($"[LOG] {msg}");
        };

        Console.WriteLine(doubler(10));
        logger("작업 시작");


    }
    static void Prac_5()
    {
        SimpleDelegate handler = delegate
        {
            Console.WriteLine("매개변수를 사용하지 않습니다.");
        };

        handler(100, "테스트");

        
    }
    static void Prac_6()
    {
        EventHandler onClick = delegate
        {
            Console.WriteLine("클릭 이벤트 발생!");
        };

        onClick(null, EventArgs.Empty);
    }
}

delegate int Calculator(int x);

delegate int Transformer(int x);

delegate void Printer(string str);

delegate void SimpleDelegate(int x, string y);

delegate void EventHanler(object obj, EventArgs e);