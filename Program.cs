// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Exercise 1: For division, create two variables called a and b.
var a=17;
var b = 4;
var quotient =a/b;
var remainder =a % b;
var product = a * b;
var sum = a +b;
var difference = a -b;
Console.WriteLine($"{a}/ {b} is {quotient} remainder {remainder}");

//Exercise 2: Define a method with some form of functionality that can be used over and over again.
Console.WriteLine("Please enter the radius of your circle");
var userInput = Console.ReadLine();
var radius = double.Parse(Console.ReadLine());

public static double AreaOfCircle (double radius)
{
    Console.WriteLine(AreaOfCircle(radius));
    var area = Math.PI * Math.Pow(radius, 2);
    return area; 
}




