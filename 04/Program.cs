Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
if ((firstNum*firstNum) % secondNum == 0 || (secondNum*secondNum) % firstNum == 0)
{
    Console.WriteLine($"Кратно");
}
else
{
    Console.WriteLine($"Не кратно");
}