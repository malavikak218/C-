Console.WriteLine("Enter the Flight Fare:");
double fare = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the booking time:");
double t = Convert.ToInt32(Console.ReadLine());

if(t > 6 && t < 9)
{
    fare = fare + (fare * 0.1);
    Console.WriteLine(fare);
}
else if(t > 9 && t < 17)
{
    fare = fare +(fare * 0.2);
    Console.WriteLine(fare);
}
else if (t > 17 &&t < 23)
{
    fare = fare + (fare * 0.07);
    Console.WriteLine(fare);
}
else if (t< 23 && t < 6)
{
    fare = fare + (fare * 0.05);
    Console.WriteLine(fare);
}

