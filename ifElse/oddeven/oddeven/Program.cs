namespace oddeven;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num = int.Parse(Console.ReadLine());
        int result = num % 2;
        if (result == 0)
        {
            Console.WriteLine($"{num} is an Even number");
        }
        else
        {
            Console.WriteLine($"{num} is an Odd number");
        }
    }
}