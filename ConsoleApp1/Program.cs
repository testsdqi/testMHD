class program
{
    static void Main()
    {
        Console.Write("Enter value: ");
        int a = int.Parse(Console.ReadLine());
        if (a==1)
        {
            Console.WriteLine("One");
        }
        else if(a==2)
        {
            Console.WriteLine("two");
        }
        else if (a == 3)
        {
            Console.WriteLine("three");
        }
        else
            Console.WriteLine("error");
        Console.ReadKey();
    }
}