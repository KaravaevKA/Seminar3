//Console.WriteLine("Введите X ");
//int num_x=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите Y ");
//int num_y=Convert.ToInt32(Console.ReadLine());
//if (num_x>0 && num_y>0)
//{
//    Console.WriteLine("1 четверть");
//}
//else if (num_x<0 && num_y>0)
//{
//    Console.WriteLine("2 четверть");
//}
//else if (num_x<0 && num_y<0)
//{
//    Console.WriteLine("3 четверть");
//}
//else if (num_x>0 && num_y<0)
//{
//    Console.WriteLine("4 четверть");
//}
//else
//{
//    Console.WriteLine("Не удовлетворяет условиям задачи");
//}
int quarter(int x, int y)
{
if (x>0 && y>0)
{
   return 1;
}
else if (x<0 && y>0)
{
   return 2;
}
else if (x<0 && y<0)
{
   return 3;
}
else if (x>0 && y<0)
{
   return 4;
}
else
{
   return 0;
}
}

Console.WriteLine("Введите X ");
int x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y ");
int y=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(quarter(x,y));