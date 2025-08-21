Using System;
class Program;
{
    Public static void Main()
    {
        int fact,num;
        Console.Write("Digite um numero: ");

        //Take input from user
        num = Convert.ToInt32(Console.readLine());

        Program obj = new Program();

        //calling recursive function 
        fact = obj.factorial(num);

        Console.WriteLine("Fatorial de {0} e {1}",num,fact);
        
    }

    //recursive function 
    public int factorial (int num)
    {
        //termination condition 
        if (num ==0)
           return 1 ;

        else 
            //recursive call 
            return num * factorial(num-1);

    }




}
