//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите число пятизначное число : ");
int a = int.Parse(Console.ReadLine()!);

int a1 = a / 10000;
int a2 = a % 10;
if(a1 == a2)
{
  int a3 = a / 1000 % 10;
  int a4 = a % 100 / 10;
  if(a3 == a4)
  {
    Console.WriteLine("Введенное число является палиндромом");
  }

}
else
Console.WriteLine("Введенное число НЕ является палиндромом");

//Console.WriteLine($"Число {a1}  и {a2} {a3} {a4}");



