// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.Write("Введите значение координаты X:");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение координаты Y:");
int Y = Convert.ToInt32(Console.ReadLine());

if(X > 0 && Y > 0)
{
    Console.WriteLine("На первой четверти");
}
else if(X < 0 && Y > 0) 
{
    Console.WriteLine("На второй четверти");
}
else if(X < 0 && Y < 0) 
{
    Console.WriteLine("На третьей четверти");
}
else if(X > 0 && Y < 0) 
{
    Console.WriteLine("На четвертой четверти");
}