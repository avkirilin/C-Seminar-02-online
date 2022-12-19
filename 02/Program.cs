Console.WriteLine("Введите первое число");
double firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
double secondNum = Convert.ToInt32(Console.ReadLine());
if (firstNum % secondNum == 0)
    {
        Console.WriteLine("Кратно");
    }
else
    {   
        Console.WriteLine($"Остаток {firstNum % secondNum}");
    }