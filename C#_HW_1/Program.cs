System.Console.WriteLine("Input two numbers & the program will compare them");
System.Console.Write("Input your first number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input your second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    System.Console.WriteLine("MAX number:" + a);
}
else if ( a == b)
{
    System.Console.WriteLine("The numbers are equal ");
}
else
{
    System.Console.WriteLine("MAX number:" + b);
}