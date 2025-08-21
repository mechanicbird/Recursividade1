Console.write("Enter the length of the Fibonacci Series: ");

string input = Console.ReadLine();

int length = 0;

if (!Int32.TryParse(input, out length))
{
    Console.WriteLine("Numero invalido")
}

for (int i=0; i< length; i++ )
{
    Console.Write("{0}",FibonacciSeries(i));
}
Console.ReadKey();

static int FibonacciSeries(int n)
{
    if(n==0) return 0; //To return the first Fibonacci number
    if(n==1) return 1;//To return the second Fibonacci number
    return FibonacciSeries(n-1) + FibonacciSeries(n-2);
}

