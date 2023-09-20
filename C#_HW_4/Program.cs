System.Console.WriteLine("Find out all even numbers from 1 to n");
System.Console.Write("Input the number n: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
if (i % 2 == 0)
{
    System.Console.WriteLine(i);
}