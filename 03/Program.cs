Console.WriteLine("Введите число");
double Num = Convert.ToInt32(Console.ReadLine());
if (Num % 7 == 0 && Num % 23 == 0)
{
    Console.WriteLine($"Число {Num} кратно числам 7 и 23");
}
else
{
    Console.WriteLine($"Не кратно);
}