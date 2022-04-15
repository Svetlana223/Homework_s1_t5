//Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
// какое меньшее. 

Console.WriteLine("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine(number1 + " больше " + number2);
}
else
{
    Console.WriteLine(number1 + " меньше " + number2);
}
