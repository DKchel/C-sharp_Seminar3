// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату X");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка в I четверти");
}

else if (X > 0 && Y < 0)
{
    Console.WriteLine("Точка в IV четверти");
}

else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка в III четверти");
}

else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка во II четверти");
}

else
{
    Console.WriteLine("Точка лежит на оси координат");
}