using System.ComponentModel.DataAnnotations;
using System.Globalization;

Console.WriteLine("Enter 5 flight fare :");
decimal[] array = new decimal[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDecimal(Console.ReadLine());
}
// Ascending order.

Console.WriteLine("sort array in ascending order");
    Array.Sort(array);
for (int j = 0; j < array.Length; j++)
{
    Console.WriteLine(array[j] + " ");
}

//Descending order.
Console.WriteLine("Descending order:");
Array.Reverse(array);
for(int k = 0;k < array.Length; k++)
{
    Console.WriteLine(array[k]);
}

//Search.
 bool b = true;
Console.WriteLine("Enter the value to be found:");
decimal value = Convert.ToDecimal(Console.ReadLine());
    for (int l = 0; l < array.Length; l++)
    {
        if (value == array[l])
        {
            Console.WriteLine("Founded the value.");
            Console.WriteLine(array[l]);

            b = true;
        }
        if (b == false)
        {
            Console.WriteLine("Value not found.");
        }
    }
    // Min and maximum fare.
   if (array.Length > 0)
    {
        decimal max = array[0];
        decimal min = array[0];
    for( int i = 0; i < array.Length; i++) 
    {
     if(max > array[i])
        {
            max = array[i];
        }
     if(min < array[i]) 
        {
            min = array[i];
        }
    }

    Console.Write("Max value:");
    Console.WriteLine(max);

    Console.Write("Min value:");
    Console.WriteLine(min);

    }

   // Duplicate values.

   int index =0;
   decimal a = 0;

   for(int i = 0; i < array.Length; i++)
{
    for( int j = 0; j < array.Length; j++)
    {
        if (array[i] == array[j]) 
        {
          index ++;
         
        }
    }
   
}
if (index != 0)
{
    Console.Write("Duplicate found.");
   
}
