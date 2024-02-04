Console.Write("Введите координату X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
  Console.WriteLine ($"Точка с координатами {x},{y} находится в I координатной плоскости");
}
else if (x<0 && y>0)
{
   Console.WriteLine ($"Точка с координатами {x},{y} находится в II координатной плоскости");
}
else if (x<0 && y<0)
{
   Console.WriteLine ($"Точка с координатами {x},{y} находится в III координатной плоскости");
}
else if (x>0 && y<0)
{
  Console.WriteLine ($"Точка с координатами {x},{y} находится в IV координатной плоскости");
}

