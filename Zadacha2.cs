﻿
int x = -2;
int y = -5;

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

