// Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2 918 -> 8
int number1 = new Random().Next(100,1000);
Console.WriteLine(number1);
int number2 = number % 10;
Console.WriteLine(number2);