namespace Loops;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Print number from 1-10");
       int numx = 1;
       while (numx <= 10)
       {
         Console.WriteLine($"{numx}");
         numx++;
       }
       
       int x = 0;
       while (x <= 0)
       {
           Console.WriteLine("Kindly enter a positive number");
           x = Int32.Parse(Console.ReadLine());
           
       }
       Console.WriteLine($"You have entered {x}");

       int num = 1;
       int total = 0;

       while (num <= 5)
       {

           total += num;
           num++;

       }
        
       Console.WriteLine($"The total is {total}");

    }
}