string quarter(int x)
{
    if (x == 1)
    {
        string x_="x>0 и y>0";
        return x_;
    }
    else if (x == 2)
    {
        string x_="x<0 и y>0";
        return x_;
    }
    else if (x == 3)
    {
        string x_="x<0 и y<0";
        return x_;
    }
    else if (x == 4)
    {
        string x_="x>0 и y<0";
        return x_;
    }
    else
    {
        string x_="Области не существует";
        return x_;
    }
}

Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(quarter(num));
