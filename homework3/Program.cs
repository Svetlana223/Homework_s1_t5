//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(number1 > number2)
{
    max = number1;
    if (number3 > number1)
    {
        max = number3;
    }
    else
    {
        max = number1;
    }
}
else
{
    max = number2;
    if(number3 > number2)
    {
        max = number3;
    }
    else
    {
        max = number2;
    }
}
 Console.WriteLine("Максимальное число " + max);


