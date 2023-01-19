Console.WriteLine("Enter the date of birth of 10 passangers:");
DateTime[] dob = new DateTime[10];
for (int i = 0;i < dob.Length; i++)
{
    dob[i] = Convert.ToDateTime(Console.ReadLine());
}
for(int i = 0;i < dob.Length; i++)
{
    var now = DateTime.Now;
    var age= now.Year - dob[i].Year;
    Console.WriteLine(age);

    if (age < 10)
    {
        Console.WriteLine("Passenger with age {0} is a kid ", age);
    }
    else if (age > 10 & age<30)
    {
        Console.WriteLine("Passenger with age {0} is a youth ", age);
    }
    else if (age > 30 & age < 60)
    {
        Console.WriteLine("Passenger with age {0} is a adult ", age);
    }
    else if (age > 60)
    {
        Console.WriteLine("Passenger with age {0} is older ", age);
    }
}

