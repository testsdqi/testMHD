class program
{
    static void Main()
    {
        Console.Write("enter number: ");
        int a = int.Parse(Console.ReadLine());
        string s = a switch
        {
            1 => "one",
            2 => "two",
            3 => "three",
            _ => "error"

        };
        Console.WriteLine(s);
    }
}