System.Console.WriteLine("Input three numbers & program will compare them");
System.Console.Write("Input your first number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input your second number: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input your third number: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        System.Console.WriteLine("MAX number: " + a);
    }
    else
    {
        System.Console.WriteLine("MAX number: " + c);
    }
    
}
    else if (b > c)
    {
        System.Console.WriteLine("MAX number: " + b);
    }
    else
    {
        System.Console.WriteLine("MAX number: " + c);
    }