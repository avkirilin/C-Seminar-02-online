int Num = new Random().Next(100,1000);
int a = Num / 100;
int b = Num / 10;
int c = Num % 10;
Console.WriteLine($"{Num}"); 
Console.WriteLine($"{a}{c}"); 