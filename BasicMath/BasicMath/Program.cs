Console.WriteLine("Enter number 1");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 2"); 
int num2=int.Parse(Console.ReadLine());
 int sum=num1 + num2;
Console.WriteLine($"The total is {sum}");
int minus=num1 - num2;
Console.WriteLine($"The difference is {minus}");
int div = num1 / num2;
Console.WriteLine($"The quotient is {div}");
int rem = num1 % num2;
Console.WriteLine($"The remainder is {rem}");

Console.WriteLine("Enter the price of a pen");

decimal price=decimal.Parse(Console.ReadLine());
decimal new_price=Math.Round(price, 2,MidpointRounding.AwayFromZero);

Console.WriteLine($"The price is {new_price}");


Console.WriteLine("Enter long integer");
long num3=long.Parse(Console.ReadLine());
Console.WriteLine($"The long integer is {num3}");


int age=int.Parse(Console.ReadLine());
Console.WriteLine($"The age is {age}");
int age2 = int.Parse(Console.ReadLine());
Console.WriteLine($"The second age is {age2}");
int sumage =age2 + age;
Console.WriteLine($"Total is {sumage}");



