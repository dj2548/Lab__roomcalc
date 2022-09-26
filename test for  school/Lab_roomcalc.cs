using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

Console.WriteLine(" Welcome to Grand Circus room detail Generator");

Console.WriteLine(" what is the Length: ");
double length = double.Parse(Console.ReadLine());

Console.WriteLine(" What is the Width: ");
double width = double.Parse(Console.ReadLine());

double area = length * width;
Console.WriteLine(" The Area is: " + area);


double perimeter =   2 * (length+width);
Console.WriteLine(" Permimeter is: " + perimeter);

double height = area / length;
Console.WriteLine(" Height is: " + height);

double volume = length * width * height;
Console.WriteLine(" Volume is: " + volume);

double surfacearea = 2 * (length * height) + 2 * (width * height) + 2 * (length * width);
Console.WriteLine(" Surface area: " + surfacearea);

if (area <= 250)
    {
    Console.WriteLine(" This room is small");
    } else if (area < 650)
{
    Console.WriteLine("This room is medium");
}   
    else if  (area >= 650)
{ 
    Console.WriteLine(" This room is large");
}
