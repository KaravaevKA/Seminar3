Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= Num)
{
    Console.WriteLine(index*index*index);
    index++;
}