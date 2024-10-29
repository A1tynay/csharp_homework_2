// Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его 
// цифры через запятую.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N > 0) 
{ 
    int res = N % 10; 
     N /= 10; 
    if (N > 0) 
    { 
         Console.Write(res + ", "); 
    } 
    else 
    { 
        Console.WriteLine(res); 
    } 
} 