using System.ComponentModel.Design;

Console.WriteLine("Enter the flightfares:");
int fare = Convert.ToInt32(Console.ReadLine());
decimal[] arr = new decimal[fare * 2];

int even = 0;
int odd = 1;

Console.WriteLine("Enter the elements:");
for (int i = 0; i < fare; i++)
{
    decimal value = Convert.ToDecimal(Console.ReadLine());
    if(value % 2 == 0)
    {
        arr[even] = value;
        even += 2;
    }
    else
    {
        arr[odd] = value;
        odd += 2;
    }
}
foreach(decimal value in arr)
{
    Console.Write(value);
}
