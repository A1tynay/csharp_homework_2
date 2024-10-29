// Напишите программу, которая принимает на вход 
// целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(10 < number && number < 99)
{
    int leftDigit = number / 10;
    int rightDigit = number % 10;
    if(leftDigit > rightDigit)
    {
        System.Console.WriteLine(leftDigit);
    }
    else
    {
         System.Console.WriteLine(rightDigit);
    }
}
else
{
    System.Console.WriteLine("Число не из отрезка [10, 99]");
}