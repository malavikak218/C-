Console.WriteLine("enter the flight fares:");
decimal[] fare = new decimal[5];
for(int i = 0;i < fare.Length; i++)
{
     fare[i] = Convert.ToDecimal(Console.ReadLine()); 
}

Console.WriteLine("Enter the destinations:");
string[] dest = new string[5];
for(int i = 0;i < dest.Length; i++)
{
    dest[i] = Console.ReadLine();
}

Console.WriteLine("Enter a number from keyboard:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < fare.Length)
{
    Console.WriteLine(fare[num]);
    Console.WriteLine(dest[num]);
}
else
{
    Console.WriteLine("An error occured.");
}