


Console.WriteLine("Введите число: "); 
int number1 = Convert.ToInt32(Console.ReadLine());
if( number1 <100)
{
    Console.WriteLine("Ошибка. Третьей цифры нет"); 
}
else 
{
    while ( number1 >= 1000)
    number1 = number1 / 10;

   int number2 = number1 % 10;
   Console.WriteLine($"Третья цифра числа: {number2}"); 
}
