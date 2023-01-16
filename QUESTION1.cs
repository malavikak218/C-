using System.Collections;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Enter the names of 10 passangers:");
string[] str = new string[10];
for (int i = 0;i < str.Length; i++)
{
    str[i] = Console.ReadLine();
}
Console.WriteLine("Names are :");
for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine(str[i] + " ");
}


// Length of names in each element.

Console.WriteLine("Length:");
for (int i = 0; i < str.Length; i++)
{
    Console.Write("Length of name is");
    Console.WriteLine(str[i].Length);
}

// Alphabetic order.

Console.WriteLine("sort array in ascending order");
Array.Sort(str);
for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine(str[i] + " ");
}



// Reverse order.
Console.Write(" Names in reverse order:");
for (int i = str.Length - 1; i > 0; i--)
{
    Console.WriteLine(str[i] + " ");

}
// Search in array and display.
bool flag = false;
Console.WriteLine("Enter the name to be found:");
var name = Console.ReadLine();
for (int i = 0; i < 10; i++)
{
    if (name == str[i])
    {
        Console.WriteLine("Name founded.");
        Console.Write("The position of the name is ");
        Console.WriteLine(i + 1);

        flag = true;
    }
}
if (flag != true)
    Console.WriteLine("not found");

// Splitting at space.

for (int i = 0; i < str.Length; i++)
{
    var words = str[i].Split(' ');
    Console.WriteLine("After splitting:");
    Array.ForEach(words, Console.WriteLine);
}

// To find duplicates.

for (int i = 0;i < str.Length; i++)
{
    for( int j = i + 1; j < str.Length; j++)
    {
        if (str[i] == str[j]) 
        {
            Console.Write("Found duplicates on :");
            Console.WriteLine(str[i]);
        }
    }

}






