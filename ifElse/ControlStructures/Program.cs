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
        
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        
        if (age <= 0)
        {
            Console.WriteLine("Age can neither be a negative or Zero value");
        }
        else if (age < 13)
        {
            Console.WriteLine("You are a child");
        }
        else if (age <= 19)
        {
            Console.WriteLine("You are a Teenager");
        }
        else if (age <= 130)
        {
            Console.WriteLine("You are an Adult");
        }

        else
        {
            Console.WriteLine("You have entered an invalid value");
            
        }
        
        
    }
    
  
}
