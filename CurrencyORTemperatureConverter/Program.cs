using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.WriteLine("Welcome! Please enter  'c' to  use the currency converter  or anything else to use  the  temperature converter.  ");
string answer = Console.ReadLine();


if (answer == "c")
{
    Console.WriteLine("You have selected the currency converter.");
    Console.WriteLine("Please enter 'a' to convert from pounds or anything else to convert from euros.");
    string choice = Console.ReadLine();

    if (choice == "a")
    {
        Console.WriteLine("Please   enter your amount in  British pounds.");
        float pounds = float.Parse(Console.ReadLine());
        float euros = pounds * 1.16f;
        Console.WriteLine("The amount in euros is " + euros.ToString("0.00"));

    }
    else
    {
        Console.WriteLine("Please enter your amount in euros.");
        float euros = float.Parse(Console.ReadLine());
        float pounds = euros / 1.16f;
        Console.WriteLine("The amount in British pounds is " + pounds.ToString("0.00"));
    }
}
else
{
    Console.WriteLine("Welcome to the temperature convertor!");
    Console.WriteLine("Please enter 'a' to convert from celsius or anything else to convert from farenheit.");
    string choice = Console.ReadLine();

    if (choice == "a")
    {
        Console.WriteLine("Enter a temperature in celsius.");
        float celsius = float.Parse(Console.ReadLine());
        float farenheit = celsius * 1.18f + 32f;
        Console.WriteLine("The teperature in farenheit is " + farenheit);
    }
    else
    {
        Console.WriteLine("Please enter a temperature in farenheit.");
        float farenheit = float.Parse(Console.ReadLine());
        float celsius = (farenheit - 32f) / 1.8f;
        Console.WriteLine("The temperature in celsius is " + celsius);
    }

}
