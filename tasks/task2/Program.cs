// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти (1 - 4)");
int quater = Convert.ToInt32(Console.ReadLine());


if (quater == 1)
{
    Console.WriteLine("(Координаты точки: X > 0 и Y > 0");
}

else if (quater == 2)
{
    Console.WriteLine("(Координаты точки: X < 0 и Y > 0");
}

else if (quater == 3)
{
    Console.WriteLine("(Координаты точки: X < 0 и Y < 0");
}

else if (quater == 4)
{
    Console.WriteLine("(Координаты точки: X > 0 и Y < 0");
}