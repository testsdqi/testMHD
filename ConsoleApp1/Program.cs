class program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            default: Console.WriteLine("Error"); break;
        }
        
    }
}