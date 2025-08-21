    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            fun(number);
            Console.ReadKey();
        }

        static void fun(int n)
        {
            if(n > 0)
            {
                Console.Write($"{n}");
                fun(n - 1);
            }
        }
    }