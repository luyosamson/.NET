namespace ControlStructures;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number to determine its status");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0) 
        {
            Console.WriteLine($"{num} is a positive number");
        }
        else if(num < 0)

        {
            Console.WriteLine($"{num} is a Negative number");
        }
        else
        {
        
            Console.WriteLine($"{num} is  Zero ");
        }
    }
    
  
}
