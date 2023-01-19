Console.WriteLine("Enter the name of the passenger:");
string name = Console.ReadLine();

Console.WriteLine("enter the total miles travelled:");
int miles = Convert.ToInt32(Console.ReadLine());

if (miles > 10000 && miles < 19999){
    Console.WriteLine("You are awarded 10 frequent flyer points ");
}
else if (miles > 20000 && miles < 49999){
    Console.WriteLine("You are awarded 20 frequent flyer points ");
}
else if (miles > 50000 && miles < 99999) { 
    Console.WriteLine("You are awarded 30 frequent flyer points ");
}
else if (miles > 100000)
{
    Console.WriteLine("You are awarded 50 frequent flyer points ");

}
